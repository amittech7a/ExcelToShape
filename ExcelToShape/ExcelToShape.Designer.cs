namespace ExcelToShape
{
    partial class ExcelToShape
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._lblXCoord = new System.Windows.Forms.Label();
            this._lblYCoord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_shape = new System.Windows.Forms.TextBox();
            this.txtBox_excel = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnOpenFolder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._btnOpenFolderShape = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel File Path:";
            // 
            // _lblXCoord
            // 
            this._lblXCoord.AutoSize = true;
            this._lblXCoord.Location = new System.Drawing.Point(12, 37);
            this._lblXCoord.Name = "_lblXCoord";
            this._lblXCoord.Size = new System.Drawing.Size(44, 13);
            this._lblXCoord.TabIndex = 1;
            this._lblXCoord.Text = "X-coord";
            // 
            // _lblYCoord
            // 
            this._lblYCoord.AutoSize = true;
            this._lblYCoord.Location = new System.Drawing.Point(247, 37);
            this._lblYCoord.Name = "_lblYCoord";
            this._lblYCoord.Size = new System.Drawing.Size(44, 13);
            this._lblYCoord.TabIndex = 2;
            this._lblYCoord.Text = "Y-coord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shape File Path";
            // 
            // txtBox_shape
            // 
            this.txtBox_shape.Location = new System.Drawing.Point(117, 61);
            this.txtBox_shape.Name = "txtBox_shape";
            this.txtBox_shape.Size = new System.Drawing.Size(271, 20);
            this.txtBox_shape.TabIndex = 4;
            // 
            // txtBox_excel
            // 
            this.txtBox_excel.Location = new System.Drawing.Point(117, 9);
            this.txtBox_excel.Name = "txtBox_excel";
            this.txtBox_excel.Size = new System.Drawing.Size(271, 20);
            this.txtBox_excel.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(117, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(334, 35);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(103, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.Location = new System.Drawing.Point(374, 87);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(63, 25);
            this._btnCancel.TabIndex = 13;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOK.Location = new System.Drawing.Point(313, 87);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(55, 25);
            this._btnOK.TabIndex = 12;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnOpenFolder
            // 
            this._btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOpenFolder.Location = new System.Drawing.Point(397, 3);
            this._btnOpenFolder.Name = "_btnOpenFolder";
            this._btnOpenFolder.Size = new System.Drawing.Size(40, 25);
            this._btnOpenFolder.TabIndex = 14;
            this._btnOpenFolder.Text = "...";
            this._btnOpenFolder.UseVisualStyleBackColor = true;
            this._btnOpenFolder.Click += new System.EventHandler(this._btnOpenFolder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _btnOpenFolderShape
            // 
            this._btnOpenFolderShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOpenFolderShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOpenFolderShape.Location = new System.Drawing.Point(397, 58);
            this._btnOpenFolderShape.Name = "_btnOpenFolderShape";
            this._btnOpenFolderShape.Size = new System.Drawing.Size(40, 25);
            this._btnOpenFolderShape.TabIndex = 15;
            this._btnOpenFolderShape.Text = "...";
            this._btnOpenFolderShape.UseVisualStyleBackColor = true;
            this._btnOpenFolderShape.Click += new System.EventHandler(this._btnOpenFolderShape_Click);
            // 
            // ExcelToShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(449, 124);
            this.Controls.Add(this._btnOpenFolderShape);
            this.Controls.Add(this._btnOpenFolder);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtBox_excel);
            this.Controls.Add(this.txtBox_shape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._lblYCoord);
            this.Controls.Add(this._lblXCoord);
            this.Controls.Add(this.label1);
            this.Name = "ExcelToShape";
            this.Text = "ExcelToShape";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblXCoord;
        private System.Windows.Forms.Label _lblYCoord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_shape;
        private System.Windows.Forms.TextBox txtBox_excel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnOpenFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button _btnOpenFolderShape;
    }
}

