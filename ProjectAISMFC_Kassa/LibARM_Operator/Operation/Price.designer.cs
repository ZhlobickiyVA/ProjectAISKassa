namespace LibARM_Operator
{
    partial class Price
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Price));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenClient = new System.Windows.Forms.ToolStripButton();
            this.OpenListAccess = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SenderPanel = new System.Windows.Forms.GroupBox();
            this.FSender = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListCat = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infocat = new System.Windows.Forms.Label();
            this.SettingPrice = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutPrice = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SumPrice = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.SetPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListDov = new System.Windows.Forms.ListBox();
            this.AddWar2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.controllabel = new System.Windows.Forms.LinkLabel();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SenderPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenClient,
            this.OpenListAccess});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenClient
            // 
            this.OpenClient.Image = global::LibARM_Operator.Properties.Resources.emblem_people_5471;
            this.OpenClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenClient.Name = "OpenClient";
            this.OpenClient.Size = new System.Drawing.Size(184, 22);
            this.OpenClient.Text = "Открыть карточку заявителя";
            this.OpenClient.Click += new System.EventHandler(this.OpenClient_Click);
            // 
            // OpenListAccess
            // 
            this.OpenListAccess.Image = global::LibARM_Operator.Properties.Resources.application_view_list_1643;
            this.OpenListAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenListAccess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenListAccess.Name = "OpenListAccess";
            this.OpenListAccess.Size = new System.Drawing.Size(188, 22);
            this.OpenListAccess.Text = "Открыть список разрещений";
            this.OpenListAccess.Click += new System.EventHandler(this.OpenListAccess_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SenderPanel);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 697);
            this.panel2.TabIndex = 8;
            // 
            // SenderPanel
            // 
            this.SenderPanel.Controls.Add(this.FSender);
            this.SenderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SenderPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SenderPanel.Location = new System.Drawing.Point(0, 239);
            this.SenderPanel.Name = "SenderPanel";
            this.SenderPanel.Padding = new System.Windows.Forms.Padding(0);
            this.SenderPanel.Size = new System.Drawing.Size(854, 300);
            this.SenderPanel.TabIndex = 12;
            this.SenderPanel.TabStop = false;
            this.SenderPanel.Text = "Управления продажей";
            // 
            // FSender
            // 
            this.FSender.AutoScroll = true;
            this.FSender.BackColor = System.Drawing.SystemColors.Control;
            this.FSender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FSender.Location = new System.Drawing.Point(0, 19);
            this.FSender.Name = "FSender";
            this.FSender.Size = new System.Drawing.Size(854, 281);
            this.FSender.TabIndex = 0;
            this.FSender.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FSender_ControlAdded);
            this.FSender.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FSender_ControlAdded);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListCat);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(0, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(20, 3, 6, 3);
            this.groupBox3.Size = new System.Drawing.Size(854, 166);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список доступных категорий для продажи";
            // 
            // ListCat
            // 
            this.ListCat.BackColor = System.Drawing.SystemColors.Window;
            this.ListCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCat.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListCat.ForeColor = System.Drawing.Color.Black;
            this.ListCat.FormattingEnabled = true;
            this.ListCat.ItemHeight = 17;
            this.ListCat.Location = new System.Drawing.Point(20, 22);
            this.ListCat.Name = "ListCat";
            this.ListCat.ScrollAlwaysVisible = true;
            this.ListCat.Size = new System.Drawing.Size(828, 95);
            this.ListCat.TabIndex = 2;
            this.ListCat.SelectedIndexChanged += new System.EventHandler(this.ListCat_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infocat);
            this.panel1.Controls.Add(this.SettingPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 117);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(828, 46);
            this.panel1.TabIndex = 1;
            // 
            // infocat
            // 
            this.infocat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infocat.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infocat.ForeColor = System.Drawing.Color.Navy;
            this.infocat.Location = new System.Drawing.Point(3, 3);
            this.infocat.Margin = new System.Windows.Forms.Padding(0);
            this.infocat.Name = "infocat";
            this.infocat.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.infocat.Size = new System.Drawing.Size(769, 40);
            this.infocat.TabIndex = 4;
            // 
            // SettingPrice
            // 
            this.SettingPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingPrice.Enabled = false;
            this.SettingPrice.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingPrice.Image = global::LibARM_Operator.Properties.Resources.configure_9933;
            this.SettingPrice.Location = new System.Drawing.Point(772, 3);
            this.SettingPrice.Name = "SettingPrice";
            this.SettingPrice.Size = new System.Drawing.Size(53, 40);
            this.SettingPrice.TabIndex = 3;
            this.SettingPrice.UseVisualStyleBackColor = true;
            this.SettingPrice.Click += new System.EventHandler(this.SettingPrice_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(0, 539);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(854, 89);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Информация для оплаты";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.054152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.02166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.07837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.07837F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutPrice);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(624, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сдача";
            // 
            // OutPrice
            // 
            this.OutPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutPrice.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutPrice.ForeColor = System.Drawing.Color.Red;
            this.OutPrice.Location = new System.Drawing.Point(3, 22);
            this.OutPrice.Name = "OutPrice";
            this.OutPrice.Size = new System.Drawing.Size(198, 33);
            this.OutPrice.TabIndex = 1;
            this.OutPrice.Text = "0,00";
            this.OutPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SumPrice);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(416, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(202, 58);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сумма для оплаты";
            // 
            // SumPrice
            // 
            this.SumPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SumPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SumPrice.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumPrice.ForeColor = System.Drawing.Color.Navy;
            this.SumPrice.Location = new System.Drawing.Point(3, 22);
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.Size = new System.Drawing.Size(196, 33);
            this.SumPrice.TabIndex = 2;
            this.SumPrice.Text = "0,00";
            this.SumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.SetPrice);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(233, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(177, 58);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Дано";
            // 
            // SetPrice
            // 
            this.SetPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetPrice.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetPrice.Location = new System.Drawing.Point(3, 22);
            this.SetPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SetPrice.Name = "SetPrice";
            this.SetPrice.Size = new System.Drawing.Size(171, 39);
            this.SetPrice.TabIndex = 6;
            this.SetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SetPrice.ThousandsSeparator = true;
            this.SetPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetPrice_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListDov);
            this.groupBox2.Controls.Add(this.AddWar2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20, 3, 5, 3);
            this.groupBox2.Size = new System.Drawing.Size(854, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация по доверенностям";
            // 
            // ListDov
            // 
            this.ListDov.BackColor = System.Drawing.SystemColors.Control;
            this.ListDov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListDov.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListDov.ForeColor = System.Drawing.Color.Navy;
            this.ListDov.FormattingEnabled = true;
            this.ListDov.ItemHeight = 17;
            this.ListDov.Location = new System.Drawing.Point(20, 22);
            this.ListDov.Name = "ListDov";
            this.ListDov.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListDov.Size = new System.Drawing.Size(776, 48);
            this.ListDov.TabIndex = 2;
            // 
            // AddWar2
            // 
            this.AddWar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddWar2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWar2.Image = global::LibARM_Operator.Properties.Resources.Addwar;
            this.AddWar2.Location = new System.Drawing.Point(796, 22);
            this.AddWar2.Name = "AddWar2";
            this.AddWar2.Size = new System.Drawing.Size(53, 48);
            this.AddWar2.TabIndex = 1;
            this.AddWar2.UseVisualStyleBackColor = true;
            this.AddWar2.Click += new System.EventHandler(this.AddWar2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 628);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 69);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Image = global::LibARM_Operator.Properties.Resources.app_jqAA_cs_50616small;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(408, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "      Провести оплату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Image = global::LibARM_Operator.Properties.Resources.deletered_2069;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(702, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отмена операции";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox8
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox8, 2);
            this.groupBox8.Controls.Add(this.controllabel);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(224, 58);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Контроль";
            // 
            // controllabel
            // 
            this.controllabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllabel.Font = new System.Drawing.Font("Times New Roman", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controllabel.LinkColor = System.Drawing.Color.Green;
            this.controllabel.Location = new System.Drawing.Point(3, 22);
            this.controllabel.Name = "controllabel";
            this.controllabel.Size = new System.Drawing.Size(218, 33);
            this.controllabel.TabIndex = 0;
            this.controllabel.TabStop = true;
            this.controllabel.Text = "Удачного дня";
            this.controllabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(680, 600);
            this.Name = "Price";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа билетов";
            this.Shown += new System.EventHandler(this.Price_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.SenderPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SetPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button AddWar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox SenderPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OutPrice;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label SumPrice;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown SetPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button AddWar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox ListCat;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label infocat;
        public System.Windows.Forms.Button SettingPrice;
        public System.Windows.Forms.ListBox ListDov;
        private System.Windows.Forms.FlowLayoutPanel FSender;
        private System.Windows.Forms.ToolStripButton OpenListAccess;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.LinkLabel controllabel;
    }
}