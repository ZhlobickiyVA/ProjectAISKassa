namespace LibTickets
{
    partial class ContPriceSer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContPriceSer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBT = new System.Windows.Forms.ToolStripButton();
            this.EditBT = new System.Windows.Forms.ToolStripButton();
            this.DeleteBT = new System.Windows.Forms.ToolStripButton();
            this.CloseBT = new System.Windows.Forms.ToolStripButton();
            this.ListControl = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListControl)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(701, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBT
            // 
            this.AddBT.Image = global::LibTickets.Properties.Resources.edit_add_8363;
            this.AddBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(79, 22);
            this.AddBT.Text = "Добавить";
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.Image = global::LibTickets.Properties.Resources.ticket__pencil_6730;
            this.EditBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(107, 22);
            this.EditBT.Text = "Редактировать";
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Image = global::LibTickets.Properties.Resources.edit_remove_8961;
            this.DeleteBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(71, 22);
            this.DeleteBT.Text = "Удалить";
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // CloseBT
            // 
            this.CloseBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseBT.Image = global::LibTickets.Properties.Resources.gtk_quit_9107;
            this.CloseBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(61, 22);
            this.CloseBT.Text = "Выход";
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // ListControl
            // 
            this.ListControl.AllowUserToAddRows = false;
            this.ListControl.AllowUserToDeleteRows = false;
            this.ListControl.AllowUserToOrderColumns = true;
            this.ListControl.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListControl.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListControl.Location = new System.Drawing.Point(0, 25);
            this.ListControl.Margin = new System.Windows.Forms.Padding(4);
            this.ListControl.MultiSelect = false;
            this.ListControl.Name = "ListControl";
            this.ListControl.ReadOnly = true;
            this.ListControl.RowTemplate.ReadOnly = true;
            this.ListControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListControl.Size = new System.Drawing.Size(701, 426);
            this.ListControl.TabIndex = 7;
            
            
            this.ListControl.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListControl_ColumnHeaderMouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ContPriceSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 451);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ListControl);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContPriceSer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Контроль доступности серии для реализации";
            this.Shown += new System.EventHandler(this.ContPriceSer_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBT;
        private System.Windows.Forms.ToolStripButton EditBT;
        private System.Windows.Forms.ToolStripButton DeleteBT;
        private System.Windows.Forms.ToolStripButton CloseBT;
        private System.Windows.Forms.DataGridView ListControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}