namespace AudioRenamer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtImportDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExportDirectory = new System.Windows.Forms.Label();
            this.txtExportDirectory = new System.Windows.Forms.TextBox();
            this.lblMappingCsvFile = new System.Windows.Forms.Label();
            this.txtMappingCsvFile = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(197, 465);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(133, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert Files";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtImportDirectory
            // 
            this.txtImportDirectory.Location = new System.Drawing.Point(25, 195);
            this.txtImportDirectory.Name = "txtImportDirectory";
            this.txtImportDirectory.Size = new System.Drawing.Size(457, 20);
            this.txtImportDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Import Directory";
            // 
            // lblExportDirectory
            // 
            this.lblExportDirectory.AutoSize = true;
            this.lblExportDirectory.Location = new System.Drawing.Point(21, 246);
            this.lblExportDirectory.Name = "lblExportDirectory";
            this.lblExportDirectory.Size = new System.Drawing.Size(82, 13);
            this.lblExportDirectory.TabIndex = 4;
            this.lblExportDirectory.Text = "Export Directory";
            // 
            // txtExportDirectory
            // 
            this.txtExportDirectory.Location = new System.Drawing.Point(25, 274);
            this.txtExportDirectory.Name = "txtExportDirectory";
            this.txtExportDirectory.Size = new System.Drawing.Size(457, 20);
            this.txtExportDirectory.TabIndex = 3;
            // 
            // lblMappingCsvFile
            // 
            this.lblMappingCsvFile.AutoSize = true;
            this.lblMappingCsvFile.Location = new System.Drawing.Point(21, 87);
            this.lblMappingCsvFile.Name = "lblMappingCsvFile";
            this.lblMappingCsvFile.Size = new System.Drawing.Size(88, 13);
            this.lblMappingCsvFile.TabIndex = 6;
            this.lblMappingCsvFile.Text = "Mapping Csv File";
            // 
            // txtMappingCsvFile
            // 
            this.txtMappingCsvFile.Location = new System.Drawing.Point(24, 116);
            this.txtMappingCsvFile.Name = "txtMappingCsvFile";
            this.txtMappingCsvFile.Size = new System.Drawing.Size(457, 20);
            this.txtMappingCsvFile.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(27, 313);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(71, 13);
            this.lblExtension.TabIndex = 8;
            this.lblExtension.Text = "File extension";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(31, 341);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(72, 20);
            this.txtExtension.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 536);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.lblMappingCsvFile);
            this.Controls.Add(this.txtMappingCsvFile);
            this.Controls.Add(this.lblExportDirectory);
            this.Controls.Add(this.txtExportDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImportDirectory);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Audio Renaming Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtImportDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExportDirectory;
        private System.Windows.Forms.TextBox txtExportDirectory;
        private System.Windows.Forms.Label lblMappingCsvFile;
        private System.Windows.Forms.TextBox txtMappingCsvFile;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txtExtension;
    }
}

