namespace LibEmployees
{
    partial class spRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spRole));
            this.ListRole = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBT = new System.Windows.Forms.ToolStripButton();
            this.EditBT = new System.Windows.Forms.ToolStripButton();
            this.DeleteBT = new System.Windows.Forms.ToolStripButton();
            this.CloseBT = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ListRole)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRole
            // 
            this.ListRole.AllowUserToAddRows = false;
            this.ListRole.AllowUserToDeleteRows = false;
            this.ListRole.AllowUserToOrderColumns = true;
            this.ListRole.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListRole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListRole.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListRole.Location = new System.Drawing.Point(0, 25);
            this.ListRole.Margin = new System.Windows.Forms.Padding(4);
            this.ListRole.MultiSelect = false;
            this.ListRole.Name = "ListRole";
            this.ListRole.ReadOnly = true;
            this.ListRole.RowTemplate.ReadOnly = true;
            this.ListRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListRole.Size = new System.Drawing.Size(457, 303);
            this.ListRole.TabIndex = 8;
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
            this.toolStrip1.Size = new System.Drawing.Size(457, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBT
            // 
            this.AddBT.Image = global::LibEmployees.Properties.Resources.edit_add_8363;
            this.AddBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(79, 22);
            this.AddBT.Text = "Добавить";
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.Image = global::LibEmployees.Properties.Resources.ticket__pencil_6730;
            this.EditBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(107, 22);
            this.EditBT.Text = "Редактировать";
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Image = global::LibEmployees.Properties.Resources.edit_remove_8961;
            this.DeleteBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(71, 22);
            this.DeleteBT.Text = "Удалить";
            // 
            // CloseBT
            // 
            this.CloseBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseBT.Image = global::LibEmployees.Properties.Resources.gtk_quit_9107;
            this.CloseBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(61, 22);
            this.CloseBT.Text = "Выход";
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(457, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // spRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 350);
            this.Controls.Add(this.ListRole);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "spRole";
            this.Text = "Справочник ролей";
            this.Load += new System.EventHandler(this.spRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListRole)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListRole;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBT;
        private System.Windows.Forms.ToolStripButton EditBT;
        private System.Windows.Forms.ToolStripButton DeleteBT;
        private System.Windows.Forms.ToolStripButton CloseBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}