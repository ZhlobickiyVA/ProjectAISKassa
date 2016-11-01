namespace LibARM_Operator
{
    partial class UPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParentPanel = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.BrakButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.StatLab = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.PriceLab = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.NumberCB = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SeriaCB = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.YearLab = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.ColorTik = new System.Windows.Forms.GroupBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ParentPanel.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ColorTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.groupBox9);
            this.ParentPanel.Controls.Add(this.groupBox8);
            this.ParentPanel.Controls.Add(this.groupBox7);
            this.ParentPanel.Controls.Add(this.groupBox6);
            this.ParentPanel.Controls.Add(this.groupBox5);
            this.ParentPanel.Controls.Add(this.groupBox4);
            this.ParentPanel.Controls.Add(this.groupBox3);
            this.ParentPanel.Controls.Add(this.ColorTik);
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentPanel.Location = new System.Drawing.Point(2, 2);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.ParentPanel.Size = new System.Drawing.Size(796, 66);
            this.ParentPanel.TabIndex = 0;
            this.ParentPanel.TabStop = false;
            this.ParentPanel.Text = "Клиент";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.BrakButton);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.Location = new System.Drawing.Point(685, 19);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox9.Size = new System.Drawing.Size(107, 43);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            // 
            // BrakButton
            // 
            this.BrakButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrakButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrakButton.Location = new System.Drawing.Point(0, 15);
            this.BrakButton.Margin = new System.Windows.Forms.Padding(5);
            this.BrakButton.Name = "BrakButton";
            this.BrakButton.Size = new System.Drawing.Size(107, 28);
            this.BrakButton.TabIndex = 0;
            this.BrakButton.Text = "Испорчен";
            this.BrakButton.UseVisualStyleBackColor = true;
            this.BrakButton.Click += new System.EventHandler(this.BrakButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.StatLab);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(554, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(107, 43);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Статус";
            // 
            // StatLab
            // 
            this.StatLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatLab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatLab.Location = new System.Drawing.Point(3, 18);
            this.StatLab.Name = "StatLab";
            this.StatLab.Size = new System.Drawing.Size(101, 22);
            this.StatLab.TabIndex = 0;
            this.StatLab.Text = "Продажа";
            this.StatLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.PriceLab);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(473, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(81, 43);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Цена";
            // 
            // PriceLab
            // 
            this.PriceLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceLab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLab.Location = new System.Drawing.Point(3, 18);
            this.PriceLab.Name = "PriceLab";
            this.PriceLab.Size = new System.Drawing.Size(75, 22);
            this.PriceLab.TabIndex = 0;
            this.PriceLab.Text = "252,20р.";
            this.PriceLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.NumberCB);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(357, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(116, 43);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Номер";
            // 
            // NumberCB
            // 
            this.NumberCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberCB.FormattingEnabled = true;
            this.NumberCB.Location = new System.Drawing.Point(3, 18);
            this.NumberCB.Name = "NumberCB";
            this.NumberCB.Size = new System.Drawing.Size(110, 23);
            this.NumberCB.TabIndex = 1;
            this.NumberCB.SelectedIndexChanged += new System.EventHandler(this.NumberCB_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SeriaCB);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(250, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(107, 43);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Серия";
            // 
            // SeriaCB
            // 
            this.SeriaCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeriaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeriaCB.FormattingEnabled = true;
            this.SeriaCB.Location = new System.Drawing.Point(3, 18);
            this.SeriaCB.Name = "SeriaCB";
            this.SeriaCB.Size = new System.Drawing.Size(101, 23);
            this.SeriaCB.TabIndex = 1;
            this.SeriaCB.SelectedIndexChanged += new System.EventHandler(this.SeriaCB_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.YearLab);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(198, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(52, 43);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Год";
            // 
            // YearLab
            // 
            this.YearLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearLab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLab.Location = new System.Drawing.Point(3, 18);
            this.YearLab.Name = "YearLab";
            this.YearLab.Size = new System.Drawing.Size(46, 22);
            this.YearLab.TabIndex = 0;
            this.YearLab.Text = "2014";
            this.YearLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MonthCB);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(91, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 43);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Месяц";
            // 
            // MonthCB
            // 
            this.MonthCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Location = new System.Drawing.Point(3, 18);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(101, 23);
            this.MonthCB.TabIndex = 0;
            this.MonthCB.SelectedIndexChanged += new System.EventHandler(this.MonthCB_SelectedIndexChanged);
            // 
            // ColorTik
            // 
            this.ColorTik.Controls.Add(this.ColorLabel);
            this.ColorTik.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColorTik.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTik.Location = new System.Drawing.Point(4, 19);
            this.ColorTik.Name = "ColorTik";
            this.ColorTik.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ColorTik.Size = new System.Drawing.Size(87, 43);
            this.ColorTik.TabIndex = 0;
            this.ColorTik.TabStop = false;
            this.ColorTik.Text = "Цвет Билета";
            // 
            // ColorLabel
            // 
            this.ColorLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorLabel.Location = new System.Drawing.Point(10, 20);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(67, 18);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.ParentPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 70);
            this.MinimumSize = new System.Drawing.Size(800, 70);
            this.Name = "UPanel";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(800, 70);
            this.ParentPanel.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ColorTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParentPanel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button BrakButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label StatLab;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label PriceLab;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label YearLab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox ColorTik;
        public System.Windows.Forms.ComboBox MonthCB;
        public System.Windows.Forms.ComboBox NumberCB;
        public System.Windows.Forms.ComboBox SeriaCB;
        private System.Windows.Forms.Label ColorLabel;
    }
}
