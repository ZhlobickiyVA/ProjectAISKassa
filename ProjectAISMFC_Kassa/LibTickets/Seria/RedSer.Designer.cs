namespace LibTickets
{
    partial class RedSer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedSer));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorpan = new System.Windows.Forms.Panel();
            this.SelectColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 20);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NameTb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel4.Size = new System.Drawing.Size(320, 68);
            this.panel4.TabIndex = 50;
            // 
            // NameTb
            // 
            this.NameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTb.Location = new System.Drawing.Point(10, 33);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(300, 26);
            this.NameTb.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "Название серии";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel2.Size = new System.Drawing.Size(320, 71);
            this.panel2.TabIndex = 51;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.33333F));
            this.tableLayoutPanel1.Controls.Add(this.colorpan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectColor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 31);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // colorpan
            // 
            this.colorpan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorpan.Location = new System.Drawing.Point(3, 3);
            this.colorpan.Name = "colorpan";
            this.colorpan.Size = new System.Drawing.Size(248, 25);
            this.colorpan.TabIndex = 45;
            // 
            // SelectColor
            // 
            this.SelectColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectColor.Location = new System.Drawing.Point(257, 3);
            this.SelectColor.Name = "SelectColor";
            this.SelectColor.Size = new System.Drawing.Size(40, 25);
            this.SelectColor.TabIndex = 46;
            this.SelectColor.Text = "...";
            this.SelectColor.UseVisualStyleBackColor = true;
            this.SelectColor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Цвет серии";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.OkBT);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.CancelBT);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(0, 175);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.panel5.Size = new System.Drawing.Size(320, 50);
            this.panel5.TabIndex = 52;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::LibTickets.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(44, 5);
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
            this.panel6.Location = new System.Drawing.Point(179, 5);
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
            this.CancelBT.Location = new System.Drawing.Point(194, 5);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(111, 40);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // RedSer
            // 
            this.AcceptButton = this.OkBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBT;
            this.ClientSize = new System.Drawing.Size(320, 225);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RedSer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Серия билетов";
            this.Load += new System.EventHandler(this.RedSer_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel colorpan;
        private System.Windows.Forms.Button SelectColor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button CancelBT;
    }
}