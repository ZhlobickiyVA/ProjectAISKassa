namespace LibDataFile
{
    partial class FormFileReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileReport));
            this.ListFile = new System.Windows.Forms.DataGridView();
            this.AddBtFile = new System.Windows.Forms.ToolStrip();
            this.RefreshFileReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListFile)).BeginInit();
            this.AddBtFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListFile
            // 
            this.ListFile.AllowUserToAddRows = false;
            this.ListFile.AllowUserToDeleteRows = false;
            this.ListFile.AllowUserToOrderColumns = true;
            this.ListFile.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListFile.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListFile.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListFile.Location = new System.Drawing.Point(0, 26);
            this.ListFile.Margin = new System.Windows.Forms.Padding(4);
            this.ListFile.MultiSelect = false;
            this.ListFile.Name = "ListFile";
            this.ListFile.ReadOnly = true;
            this.ListFile.RowTemplate.ReadOnly = true;
            this.ListFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListFile.Size = new System.Drawing.Size(616, 393);
            this.ListFile.TabIndex = 61;
            // 
            // AddBtFile
            // 
            this.AddBtFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshFileReport,
            this.toolStripButton1});
            this.AddBtFile.Location = new System.Drawing.Point(0, 0);
            this.AddBtFile.Name = "AddBtFile";
            this.AddBtFile.Size = new System.Drawing.Size(616, 26);
            this.AddBtFile.TabIndex = 60;
            this.AddBtFile.Text = "toolStrip2";
            // 
            // RefreshFileReport
            // 
            this.RefreshFileReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshFileReport.Name = "RefreshFileReport";
            this.RefreshFileReport.Size = new System.Drawing.Size(78, 23);
            this.RefreshFileReport.Text = "Добавить";
            this.RefreshFileReport.Click += new System.EventHandler(this.RefreshFileReport_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 23);
            this.toolStripButton1.Text = "Удалить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormFileReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 419);
            this.Controls.Add(this.ListFile);
            this.Controls.Add(this.AddBtFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFileReport";
            this.Text = "Форма обновления шаблоновэ";
            ((System.ComponentModel.ISupportInitialize)(this.ListFile)).EndInit();
            this.AddBtFile.ResumeLayout(false);
            this.AddBtFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView ListFile;
        private System.Windows.Forms.ToolStrip AddBtFile;
        private System.Windows.Forms.ToolStripButton RefreshFileReport;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}