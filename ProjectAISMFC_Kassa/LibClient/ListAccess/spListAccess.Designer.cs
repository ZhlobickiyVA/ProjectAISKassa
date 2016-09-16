namespace ListAccess
{
    partial class spListAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spListAccess));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBT = new System.Windows.Forms.ToolStripButton();
            this.EditBT = new System.Windows.Forms.ToolStripButton();
            this.DeleteBT = new System.Windows.Forms.ToolStripButton();
            this.CloseBT = new System.Windows.Forms.ToolStripButton();
            this.CopyBT = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CatCB = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListAcess = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAcess)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBT,
            this.EditBT,
            this.DeleteBT,
            this.CloseBT,
            this.CopyBT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1161, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBT
            // 
            this.AddBT.Image = global::LibClient.Properties.Resources.edit_add_8363;
            this.AddBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(79, 22);
            this.AddBT.Text = "Добавить";
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.Image = global::LibClient.Properties.Resources.ticket__pencil_6730;
            this.EditBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(107, 22);
            this.EditBT.Text = "Редактировать";
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Image = global::LibClient.Properties.Resources.edit_remove_8961;
            this.DeleteBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(71, 22);
            this.DeleteBT.Text = "Удалить";
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // CloseBT
            // 
            this.CloseBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseBT.Image = global::LibClient.Properties.Resources.gtk_quit_9107;
            this.CloseBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(61, 22);
            this.CloseBT.Text = "Выход";
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // CopyBT
            // 
            this.CopyBT.Image = global::LibClient.Properties.Resources.Copy;
            this.CopyBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyBT.Name = "CopyBT";
            this.CopyBT.Size = new System.Drawing.Size(265, 22);
            this.CopyBT.Text = "Копировать выборку на следующий месяц";
            this.CopyBT.Click += new System.EventHandler(this.CopyBT_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.panel1.Size = new System.Drawing.Size(300, 440);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(294, 97);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CatCB);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(10, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(279, 62);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Категория";
            // 
            // CatCB
            // 
            this.CatCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Location = new System.Drawing.Point(5, 24);
            this.CatCB.Name = "CatCB";
            this.CatCB.Size = new System.Drawing.Size(269, 27);
            this.CatCB.TabIndex = 6;
            this.CatCB.SelectedIndexChanged += new System.EventHandler(this.CatCB_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel8);
            this.groupBox7.Controls.Add(this.panel9);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(3, 326);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.groupBox7.Size = new System.Drawing.Size(294, 114);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Фильтр по времени";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.YearCB);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 58);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.panel8.Size = new System.Drawing.Size(279, 36);
            this.panel8.TabIndex = 1;
            // 
            // YearCB
            // 
            this.YearCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearCB.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Items.AddRange(new object[] {
            "<Без фильтра>",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.YearCB.Location = new System.Drawing.Point(63, 5);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(211, 27);
            this.YearCB.TabIndex = 7;
            this.YearCB.SelectedIndexChanged += new System.EventHandler(this.YearCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Год";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.MonthCB);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(10, 22);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.panel9.Size = new System.Drawing.Size(279, 36);
            this.panel9.TabIndex = 0;
            // 
            // MonthCB
            // 
            this.MonthCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCB.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Items.AddRange(new object[] {
            "<Без фильтра>",
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.MonthCB.Location = new System.Drawing.Point(63, 5);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(211, 27);
            this.MonthCB.TabIndex = 7;
            this.MonthCB.SelectedIndexChanged += new System.EventHandler(this.MonthCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Месяц";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.ListAcess);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 25);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(861, 440);
            this.panel2.TabIndex = 11;
            // 
            // ListAcess
            // 
            this.ListAcess.AllowUserToAddRows = false;
            this.ListAcess.AllowUserToDeleteRows = false;
            this.ListAcess.AllowUserToOrderColumns = true;
            this.ListAcess.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListAcess.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListAcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListAcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListAcess.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListAcess.Location = new System.Drawing.Point(3, 60);
            this.ListAcess.Margin = new System.Windows.Forms.Padding(4);
            this.ListAcess.MultiSelect = false;
            this.ListAcess.Name = "ListAcess";
            this.ListAcess.ReadOnly = true;
            this.ListAcess.RowTemplate.ReadOnly = true;
            this.ListAcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListAcess.Size = new System.Drawing.Size(855, 374);
            this.ListAcess.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(855, 57);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(5, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(845, 26);
            this.textBox1.TabIndex = 0;
            // 
            // spListAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(16, 400);
            this.Name = "spListAccess";
            this.Text = "Списки клиентов";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListAcess)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton CopyBT;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox YearCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox MonthCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CatCB;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView ListAcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}