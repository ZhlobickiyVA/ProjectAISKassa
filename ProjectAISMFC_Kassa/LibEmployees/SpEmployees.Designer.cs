namespace LibEmployees
{
    partial class FspEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FspEmployees));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBT = new System.Windows.Forms.ToolStripButton();
            this.EditBT = new System.Windows.Forms.ToolStripButton();
            this.DeleteBT = new System.Windows.Forms.ToolStripButton();
            this.CloseBT = new System.Windows.Forms.ToolStripButton();
            this.RunSpRole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearPassword = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ListEmpl = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(709, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBT,
            this.EditBT,
            this.DeleteBT,
            this.CloseBT,
            this.RunSpRole,
            this.toolStripSeparator1,
            this.ClearPassword,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 25);
            this.toolStrip1.TabIndex = 4;
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
            this.CloseBT.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // RunSpRole
            // 
            this.RunSpRole.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RunSpRole.Image = global::LibEmployees.Properties.Resources.Role;
            this.RunSpRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunSpRole.Name = "RunSpRole";
            this.RunSpRole.Size = new System.Drawing.Size(132, 22);
            this.RunSpRole.Text = "Справочник ролей";
            this.RunSpRole.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ClearPassword
            // 
            this.ClearPassword.Image = global::LibEmployees.Properties.Resources.ResetPassword;
            this.ClearPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearPassword.Name = "ClearPassword";
            this.ClearPassword.Size = new System.Drawing.Size(123, 22);
            this.ClearPassword.Text = "Сбросить пароль";
            this.ClearPassword.Click += new System.EventHandler(this.ClearPassword_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ListEmpl
            // 
            this.ListEmpl.AllowUserToAddRows = false;
            this.ListEmpl.AllowUserToDeleteRows = false;
            this.ListEmpl.AllowUserToOrderColumns = true;
            this.ListEmpl.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListEmpl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListEmpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListEmpl.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListEmpl.Location = new System.Drawing.Point(0, 25);
            this.ListEmpl.Margin = new System.Windows.Forms.Padding(4);
            this.ListEmpl.MultiSelect = false;
            this.ListEmpl.Name = "ListEmpl";
            this.ListEmpl.ReadOnly = true;
            this.ListEmpl.RowTemplate.ReadOnly = true;
            this.ListEmpl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListEmpl.Size = new System.Drawing.Size(709, 453);
            this.ListEmpl.TabIndex = 5;
            // 
            // FspEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 500);
            this.Controls.Add(this.ListEmpl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FspEmployees";
            this.Text = "Справочник сотрудников";
            this.Load += new System.EventHandler(this.spEmployees_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBT;
        private System.Windows.Forms.ToolStripButton EditBT;
        private System.Windows.Forms.ToolStripButton DeleteBT;
        private System.Windows.Forms.DataGridView ListEmpl;
        private System.Windows.Forms.ToolStripButton CloseBT;
        private System.Windows.Forms.ToolStripButton RunSpRole;
        private System.Windows.Forms.ToolStripButton ClearPassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}