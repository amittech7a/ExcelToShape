using MapWinGIS;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToShape
{
    public partial class ExcelToShape : Form
    {
        public int x_Index;
        public int y_Index;

        public ExcelToShape()
        {
            InitializeComponent();
        }

        private void _btnOpenFolder_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
            this.openFileDialog1.Title = "Select Excel";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBox_excel.Text = openFileDialog1.FileName;
            }
        }

        private void _btnOpenFolderShape_Click(object sender, EventArgs e)
        {
            var fileDlg = new FolderBrowserDialog();
            fileDlg.Description = "Select Path";
            if (fileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBox_shape.Text = fileDlg.SelectedPath;
            }
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            if (txtBox_shape.Text != string.Empty && txtBox_excel.Text != string.Empty)
            {
                if (File.Exists(txtBox_excel.Text))
                {
                    // Read Excel file
                    
                    DataTable dataTable = ReadExcel(txtBox_excel.Text);

                    // Create Shape file
                    CreateShape(txtBox_excel.Text, dataTable);
                    MessageBox.Show("Successfully created Shape file");
                    Environment.Exit(0);
                }
            }
        }

        private DataTable ReadExcel(string path, bool hasHeader = true)
        {
            ExcelPackage package = new ExcelPackage(new FileInfo(path));
            ExcelWorkbook wb = package.Workbook;
            ExcelWorksheets wsList = wb.Worksheets;
            ExcelWorksheet ws = wsList[1];
            
            DataTable tbl = new DataTable();
            foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
            {
                tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
            }
            var startRow = hasHeader ? 2 : 1;
            for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
            {
                var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                DataRow row = tbl.Rows.Add();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
            }
            return tbl;

        }

        
        private void CreateShape(string path, DataTable dataTable)
        {
            Shapefile myShapefile;
            try
            {
                myShapefile = new Shapefile();
                 string fileName = Path.GetFileNameWithoutExtension(txtBox_excel.Text);
                string shapeilePath = Path.GetDirectoryName(path) + "\\" + fileName + ".shp";

                Directory.CreateDirectory(Path.GetDirectoryName(shapeilePath));

                myShapefile.CreateNew(shapeilePath, ShpfileType.SHP_POINT);
                //Create new field
                MapWinGIS.Field myField = new Field();
                //Set the field properties
                myField.Name = "ID";
                myField.Type = FieldType.INTEGER_FIELD;
                myField.Width = 10;
                //Add the filed for the shapefile table
                int intFieldIndex = 1;
                myShapefile.EditInsertField(myField, ref intFieldIndex, null);
                int myCounter = 0;
                int myShapeIndex = 0;

                //First Create header 
                CreateHeader(dataTable.Columns, myShapefile);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                     MapWinGIS.Shape myShape = new Shape();
                     myShape.Create(ShpfileType.SHP_POINT);
                     MapWinGIS.Point myPoint = new MapWinGIS.Point();
                     myPoint.x = Convert.ToDouble(dataTable.Rows[i][x_Index]);
                     myPoint.y = Convert.ToDouble(dataTable.Rows[i][y_Index]);
                     object fld_Value = dataTable.Rows[i][0];
                     int myPointIndex = 0;
                     myShape.InsertPoint(myPoint, ref myPointIndex);
                     myShapefile.EditInsertShape(myShape, ref myShapeIndex);
                     myShapefile.EditCellValue(0, myShapeIndex, fld_Value);
                     CreatePointData(dataTable, myShapefile, myShapeIndex, i);
                     myShapeIndex++;
                     myCounter++;
                }
                GeoProjection proj = new GeoProjection();
                // EPSG code
                proj.ImportFromEPSG(4326);  // WGS84
               
                myShapefile.GeoProjection = proj;
                myShapefile.StopEditingShapes(true, true, null);
                myShapefile.Close();                    
            }
            catch (Exception)
            {
                
                throw;
            }
        }
                
        
        private void CreateHeader(DataColumnCollection sentence, Shapefile myShapefile)
        {
            int intFieldIndex = 1;

            foreach (object header in sentence)
            {
                MapWinGIS.Field myField = new Field();
                //Set the field properties
                myField.Name = header.ToString();
                myField.Type = FieldType.STRING_FIELD;
                myField.Width = 10;
                //Add the filed for the shapefile table                
                bool isInserted = myShapefile.EditInsertField(myField, ref intFieldIndex, null);
                intFieldIndex++;
            }            
        }

        private void CreatePointData(DataTable dataTable, Shapefile myShapefile, int myShapeIndex , int rowIndex)
        {
            int intFieldIndex = 1;
            string fld_Value = string.Empty;
            
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                myShapefile.EditCellValue(intFieldIndex, myShapeIndex, dataTable.Rows[rowIndex][i]);
                intFieldIndex++;
            }           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            x_Index = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            y_Index = (int)numericUpDown2.Value;
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
