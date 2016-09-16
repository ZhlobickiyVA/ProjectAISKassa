namespace LibTickets
{
    partial class RedAddTik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedAddTik));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmplCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WhereLV = new System.Windows.Forms.ListView();
            this.cSeria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddListTik = new System.Windows.Forms.Button();
            this.RemoveListTik = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SeriesCB = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.FromUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.CountUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromUD)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmplCB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(813, 61);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // EmplCB
            // 
            this.EmplCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmplCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmplCB.FormattingEnabled = true;
            this.EmplCB.Location = new System.Drawing.Point(188, 24);
            this.EmplCB.Margin = new System.Windows.Forms.Padding(4);
            this.EmplCB.Name = "EmplCB";
            this.EmplCB.Size = new System.Drawing.Size(620, 27);
            this.EmplCB.TabIndex = 2;
            this.EmplCB.SelectedIndexChanged += new System.EventHandler(this.EmplCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отвественный сотрудник";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OkBT);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CancelBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(5, 406);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.panel1.Size = new System.Drawing.Size(813, 50);
            this.panel1.TabIndex = 4;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::LibTickets.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(537, 5);
            this.OkBT.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(135, 40);
            this.OkBT.TabIndex = 4;
            this.OkBT.Text = "Сохранить";
            this.OkBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OkBT.UseVisualStyleBackColor = true;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(672, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 40);
            this.panel3.TabIndex = 3;
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBT.Image = global::LibTickets.Properties.Resources.button_cancel_6569;
            this.CancelBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBT.Location = new System.Drawing.Point(687, 5);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(111, 40);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WhereLV);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(5, 66);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(813, 340);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Описание билетов входящих в поставку";
            // 
            // WhereLV
            // 
            this.WhereLV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.WhereLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cSeria,
            this.cFrom,
            this.cTO});
            this.WhereLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WhereLV.FullRowSelect = true;
            this.WhereLV.GridLines = true;
            this.WhereLV.HideSelection = false;
            this.WhereLV.Location = new System.Drawing.Point(5, 94);
            this.WhereLV.Margin = new System.Windows.Forms.Padding(4);
            this.WhereLV.MultiSelect = false;
            this.WhereLV.Name = "WhereLV";
            this.WhereLV.Size = new System.Drawing.Size(753, 241);
            this.WhereLV.TabIndex = 7;
            this.WhereLV.UseCompatibleStateImageBehavior = false;
            this.WhereLV.View = System.Windows.Forms.View.Details;
            // 
            // cSeria
            // 
            this.cSeria.Text = "Серия";
            this.cSeria.Width = 125;
            // 
            // cFrom
            // 
            this.cFrom.Text = "Начальное значение";
            this.cFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cFrom.Width = 161;
            // 
            // cTO
            // 
            this.cTO.Text = "Количество";
            this.cTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cTO.Width = 127;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddListTik, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RemoveListTik, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(758, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(50, 241);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // AddListTik
            // 
            this.AddListTik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddListTik.Image = global::LibTickets.Properties.Resources.edit_add_8363;
            this.AddListTik.Location = new System.Drawing.Point(8, 13);
            this.AddListTik.Name = "AddListTik";
            this.AddListTik.Size = new System.Drawing.Size(34, 34);
            this.AddListTik.TabIndex = 0;
            this.AddListTik.UseVisualStyleBackColor = true;
            this.AddListTik.Click += new System.EventHandler(this.AddListTik_Click);
            // 
            // RemoveListTik
            // 
            this.RemoveListTik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveListTik.Image = global::LibTickets.Properties.Resources.edit_remove_8961;
            this.RemoveListTik.Location = new System.Drawing.Point(8, 63);
            this.RemoveListTik.Name = "RemoveListTik";
            this.RemoveListTik.Size = new System.Drawing.Size(34, 34);
            this.RemoveListTik.TabIndex = 1;
            this.RemoveListTik.UseVisualStyleBackColor = true;
            this.RemoveListTik.Click += new System.EventHandler(this.RemoveListTik_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 70);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.groupBox7);
            this.flowLayoutPanel1.Controls.Add(this.groupBox8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(803, 70);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SeriesCB);
            this.groupBox6.Location = new System.Drawing.Point(4, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(258, 59);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Серия";
            // 
            // SeriesCB
            // 
            this.SeriesCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeriesCB.FormattingEnabled = true;
            this.SeriesCB.Location = new System.Drawing.Point(4, 23);
            this.SeriesCB.Margin = new System.Windows.Forms.Padding(4);
            this.SeriesCB.Name = "SeriesCB";
            this.SeriesCB.Size = new System.Drawing.Size(250, 27);
            this.SeriesCB.TabIndex = 5;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.FromUD);
            this.groupBox7.Location = new System.Drawing.Point(270, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(258, 59);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Начальное значение";
            // 
            // FromUD
            // 
            this.FromUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromUD.Location = new System.Drawing.Point(4, 23);
            this.FromUD.Margin = new System.Windows.Forms.Padding(4);
            this.FromUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.FromUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromUD.Name = "FromUD";
            this.FromUD.Size = new System.Drawing.Size(250, 26);
            this.FromUD.TabIndex = 3;
            this.FromUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FromUD.ThousandsSeparator = true;
            this.FromUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.CountUD);
            this.groupBox8.Location = new System.Drawing.Point(536, 4);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(258, 59);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Количество";
            // 
            // CountUD
            // 
            this.CountUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountUD.Location = new System.Drawing.Point(4, 23);
            this.CountUD.Margin = new System.Windows.Forms.Padding(4);
            this.CountUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CountUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountUD.Name = "CountUD";
            this.CountUD.Size = new System.Drawing.Size(250, 26);
            this.CountUD.TabIndex = 2;
            this.CountUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CountUD.ThousandsSeparator = true;
            this.CountUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RedAddTik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(832, 500);
            this.Name = "RedAddTik";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Конструктор добавления партии билетов";
            this.Load += new System.EventHandler(this.RedAddTik_Load);
            
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FromUD)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox EmplCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView WhereLV;
        private System.Windows.Forms.ColumnHeader cSeria;
        private System.Windows.Forms.ColumnHeader cFrom;
        private System.Windows.Forms.ColumnHeader cTO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddListTik;
        private System.Windows.Forms.Button RemoveListTik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox SeriesCB;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.NumericUpDown FromUD;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.NumericUpDown CountUD;
    }
}