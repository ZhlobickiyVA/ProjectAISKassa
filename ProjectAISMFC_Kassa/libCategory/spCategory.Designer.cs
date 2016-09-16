namespace libCategory
{
    partial class spCategory
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spCategory));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBT = new System.Windows.Forms.ToolStripButton();
            this.EditBT = new System.Windows.Forms.ToolStripButton();
            this.DeleteBT = new System.Windows.Forms.ToolStripButton();
            this.CloseBT = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ListCat = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCat)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBT,
            this.EditBT,
            this.DeleteBT,
            this.CloseBT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(768, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBT
            // 
            this.AddBT.Image = global::libCategory.Properties.Resources.edit_add_8363;
            this.AddBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(79, 22);
            this.AddBT.Text = "Добавить";
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.Image = global::libCategory.Properties.Resources.ticket__pencil_6730;
            this.EditBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(107, 22);
            this.EditBT.Text = "Редактировать";
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Image = global::libCategory.Properties.Resources.edit_remove_8961;
            this.DeleteBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(71, 22);
            this.DeleteBT.Text = "Удалить";
            // 
            // CloseBT
            // 
            this.CloseBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseBT.Image = global::libCategory.Properties.Resources.gtk_quit_9107;
            this.CloseBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(61, 22);
            this.CloseBT.Text = "Выход";
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 368);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ListCat
            // 
            this.ListCat.AllowUserToAddRows = false;
            this.ListCat.AllowUserToDeleteRows = false;
            this.ListCat.AllowUserToOrderColumns = true;
            this.ListCat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListCat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCat.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListCat.Location = new System.Drawing.Point(0, 25);
            this.ListCat.Margin = new System.Windows.Forms.Padding(4);
            this.ListCat.MultiSelect = false;
            this.ListCat.Name = "ListCat";
            this.ListCat.ReadOnly = true;
            this.ListCat.RowTemplate.ReadOnly = true;
            this.ListCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCat.Size = new System.Drawing.Size(768, 343);
            this.ListCat.TabIndex = 8;
            // 
            // spCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 390);
            this.Controls.Add(this.ListCat);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "spCategory";
            this.Text = "Справочник категорий";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBT;
        private System.Windows.Forms.ToolStripButton EditBT;
        private System.Windows.Forms.ToolStripButton DeleteBT;
        private System.Windows.Forms.ToolStripButton CloseBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.DataGridView ListCat;
    }
}