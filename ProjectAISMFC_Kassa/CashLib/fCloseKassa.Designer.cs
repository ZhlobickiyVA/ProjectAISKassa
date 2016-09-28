namespace CashLib
{
    partial class fCloseKas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCloseKas));
            this.panel9 = new System.Windows.Forms.Panel();
            this.ShowReport = new System.Windows.Forms.Button();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SoldoBeginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SummaInKassa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OstInKassa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.KlReestrTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FioGLBuhTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.EmplKomyCB = new System.Windows.Forms.ComboBox();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.ShowReport);
            this.panel9.Controls.Add(this.OkBT);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.CancelBT);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel9.Location = new System.Drawing.Point(5, 298);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.panel9.Size = new System.Drawing.Size(483, 50);
            this.panel9.TabIndex = 59;
            // 
            // ShowReport
            // 
            this.ShowReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowReport.Image = global::CashLib.Properties.Resources.image;
            this.ShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowReport.Location = new System.Drawing.Point(6, 5);
            this.ShowReport.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.ShowReport.Name = "ShowReport";
            this.ShowReport.Size = new System.Drawing.Size(194, 40);
            this.ShowReport.TabIndex = 5;
            this.ShowReport.Text = "Cформировать отчет";
            this.ShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowReport.UseVisualStyleBackColor = true;
            this.ShowReport.Click += new System.EventHandler(this.ShowReport_Click);
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::CashLib.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(200, 5);
            this.OkBT.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(142, 40);
            this.OkBT.TabIndex = 4;
            this.OkBT.Text = "Закрыть кассу";
            this.OkBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OkBT.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel10.Location = new System.Drawing.Point(342, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(15, 40);
            this.panel10.TabIndex = 3;
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBT.Image = global::CashLib.Properties.Resources.button_cancel_6569;
            this.CancelBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBT.Location = new System.Drawing.Point(357, 5);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(111, 40);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SoldoBeginTB);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.Location = new System.Drawing.Point(5, 10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel6.Size = new System.Drawing.Size(483, 39);
            this.panel6.TabIndex = 60;
            // 
            // SoldoBeginTB
            // 
            this.SoldoBeginTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoldoBeginTB.Enabled = false;
            this.SoldoBeginTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoldoBeginTB.Location = new System.Drawing.Point(271, 7);
            this.SoldoBeginTB.Name = "SoldoBeginTB";
            this.SoldoBeginTB.Size = new System.Drawing.Size(202, 26);
            this.SoldoBeginTB.TabIndex = 44;
            this.SoldoBeginTB.Text = "0,00";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Остаток на начало дня";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SummaInKassa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(5, 49);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel1.Size = new System.Drawing.Size(483, 39);
            this.panel1.TabIndex = 61;
            // 
            // SummaInKassa
            // 
            this.SummaInKassa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaInKassa.Enabled = false;
            this.SummaInKassa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaInKassa.Location = new System.Drawing.Point(271, 7);
            this.SummaInKassa.Name = "SummaInKassa";
            this.SummaInKassa.Size = new System.Drawing.Size(202, 26);
            this.SummaInKassa.TabIndex = 44;
            this.SummaInKassa.Text = "0,00";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Сумма в кассе ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OstInKassa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(5, 88);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel2.Size = new System.Drawing.Size(483, 39);
            this.panel2.TabIndex = 62;
            // 
            // OstInKassa
            // 
            this.OstInKassa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OstInKassa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OstInKassa.Location = new System.Drawing.Point(271, 7);
            this.OstInKassa.Name = "OstInKassa";
            this.OstInKassa.Size = new System.Drawing.Size(202, 26);
            this.OstInKassa.TabIndex = 44;
            this.OstInKassa.Text = "0,00";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Сальдо на конец дня";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.KlReestrTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(5, 127);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel3.Size = new System.Drawing.Size(483, 39);
            this.panel3.TabIndex = 63;
            // 
            // KlReestrTB
            // 
            this.KlReestrTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KlReestrTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KlReestrTB.Location = new System.Drawing.Point(271, 7);
            this.KlReestrTB.Name = "KlReestrTB";
            this.KlReestrTB.Size = new System.Drawing.Size(202, 26);
            this.KlReestrTB.TabIndex = 44;
            this.KlReestrTB.Text = "0";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Сдано в кассу реестров";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EmplKomyCB);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(5, 166);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel4.Size = new System.Drawing.Size(483, 39);
            this.panel4.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Кому передаем денежные средства";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.FioGLBuhTB);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(5, 205);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel5.Size = new System.Drawing.Size(483, 39);
            this.panel5.TabIndex = 65;
            // 
            // FioGLBuhTB
            // 
            this.FioGLBuhTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FioGLBuhTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioGLBuhTB.Location = new System.Drawing.Point(271, 7);
            this.FioGLBuhTB.Name = "FioGLBuhTB";
            this.FioGLBuhTB.Size = new System.Drawing.Size(202, 26);
            this.FioGLBuhTB.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Главный бухгалтер";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info
            // 
            this.Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.Info.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.ForeColor = System.Drawing.Color.DarkRed;
            this.Info.Location = new System.Drawing.Point(5, 244);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(483, 36);
            this.Info.TabIndex = 66;
            this.Info.Text = "label7";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmplKomyCB
            // 
            this.EmplKomyCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmplKomyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmplKomyCB.FormattingEnabled = true;
            this.EmplKomyCB.Location = new System.Drawing.Point(271, 7);
            this.EmplKomyCB.Name = "EmplKomyCB";
            this.EmplKomyCB.Size = new System.Drawing.Size(202, 27);
            this.EmplKomyCB.TabIndex = 44;
            // 
            // fCloseKas
            // 
            this.AcceptButton = this.OkBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBT;
            this.ClientSize = new System.Drawing.Size(493, 348);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fCloseKas";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закрытие кассы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fCloseKas_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCloseKas_FormClosed);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox SoldoBeginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SummaInKassa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox OstInKassa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox KlReestrTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox FioGLBuhTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ShowReport;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.ComboBox EmplKomyCB;
    }
}