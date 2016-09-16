namespace LibTickets
{
    partial class RedControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SeriesCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.DateE = new System.Windows.Forms.DateTimePicker();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.DateB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeriesCB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.groupBox1.Size = new System.Drawing.Size(574, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Серия";
            // 
            // SeriesCB
            // 
            this.SeriesCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeriesCB.FormattingEnabled = true;
            this.SeriesCB.Location = new System.Drawing.Point(15, 34);
            this.SeriesCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeriesCB.Name = "SeriesCB";
            this.SeriesCB.Size = new System.Drawing.Size(544, 27);
            this.SeriesCB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MonthCB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.groupBox2.Size = new System.Drawing.Size(574, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Месяц";
            // 
            // MonthCB
            // 
            this.MonthCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Items.AddRange(new object[] {
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
            this.MonthCB.Location = new System.Drawing.Point(15, 34);
            this.MonthCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(544, 27);
            this.MonthCB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ActiveCB);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 168);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.groupBox4.Size = new System.Drawing.Size(574, 72);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Активация";
            // 
            // ActiveCB
            // 
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveCB.Location = new System.Drawing.Point(15, 34);
            this.ActiveCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(544, 23);
            this.ActiveCB.TabIndex = 0;
            this.ActiveCB.Text = "Активация правила";
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.OkBT);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.CancelBT);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(0, 358);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.panel5.Size = new System.Drawing.Size(574, 50);
            this.panel5.TabIndex = 54;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::LibTickets.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(298, 5);
            this.OkBT.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(135, 40);
            this.OkBT.TabIndex = 4;
            this.OkBT.Text = "Сохранить";
            this.OkBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OkBT.UseVisualStyleBackColor = true;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.Location = new System.Drawing.Point(433, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 40);
            this.panel6.TabIndex = 3;
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBT.Image = global::LibTickets.Properties.Resources.button_cancel_6569;
            this.CancelBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBT.Location = new System.Drawing.Point(448, 5);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(111, 40);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tableLayoutPanel2);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox10.Location = new System.Drawing.Point(0, 259);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(10, 5, 15, 15);
            this.groupBox10.Size = new System.Drawing.Size(574, 99);
            this.groupBox10.TabIndex = 58;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Даты действия правила";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox11, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.DateE);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox12.Location = new System.Drawing.Point(278, 4);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox12.Size = new System.Drawing.Size(267, 52);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Дата окончания";
            // 
            // DateE
            // 
            this.DateE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateE.Location = new System.Drawing.Point(8, 26);
            this.DateE.Margin = new System.Windows.Forms.Padding(4);
            this.DateE.Name = "DateE";
            this.DateE.Size = new System.Drawing.Size(251, 26);
            this.DateE.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.DateB);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox11.Location = new System.Drawing.Point(4, 4);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox11.Size = new System.Drawing.Size(266, 52);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Дата начала";
            // 
            // DateB
            // 
            this.DateB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateB.Location = new System.Drawing.Point(8, 26);
            this.DateB.Margin = new System.Windows.Forms.Padding(4);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(250, 26);
            this.DateB.TabIndex = 0;
            // 
            // RedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 408);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RedControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Правило реализации";
            this.Load += new System.EventHandler(this.RedControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox SeriesCB;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox MonthCB;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.CheckBox ActiveCB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox12;
        public System.Windows.Forms.DateTimePicker DateE;
        private System.Windows.Forms.GroupBox groupBox11;
        public System.Windows.Forms.DateTimePicker DateB;
    }
}