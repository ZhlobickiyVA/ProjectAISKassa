namespace ListAccess
{
    partial class RedListAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedListAccess));
            this.panel9 = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.ClientNameTB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FioClientTB = new System.Windows.Forms.TextBox();
            this.SelectClientBT = new System.Windows.Forms.Button();
            this.SubClientNameTB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectSubClientBT = new System.Windows.Forms.Button();
            this.FIOsubClientTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoteTB = new System.Windows.Forms.TextBox();
            this.panel9.SuspendLayout();
            this.ClientNameTB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SubClientNameTB.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.OkBT);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.CancelBT);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel9.Location = new System.Drawing.Point(10, 344);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.panel9.Size = new System.Drawing.Size(567, 50);
            this.panel9.TabIndex = 59;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::LibClient.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(291, 5);
            this.OkBT.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(135, 40);
            this.OkBT.TabIndex = 4;
            this.OkBT.Text = "Сохранить";
            this.OkBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OkBT.UseVisualStyleBackColor = true;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel10.Location = new System.Drawing.Point(426, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(15, 40);
            this.panel10.TabIndex = 3;
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBT.Image = global::LibClient.Properties.Resources.button_cancel_6569;
            this.CancelBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBT.Location = new System.Drawing.Point(441, 5);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(111, 40);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // ClientNameTB
            // 
            this.ClientNameTB.Controls.Add(this.tableLayoutPanel1);
            this.ClientNameTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientNameTB.Location = new System.Drawing.Point(10, 10);
            this.ClientNameTB.Name = "ClientNameTB";
            this.ClientNameTB.Padding = new System.Windows.Forms.Padding(10);
            this.ClientNameTB.Size = new System.Drawing.Size(567, 71);
            this.ClientNameTB.TabIndex = 60;
            this.ClientNameTB.TabStop = false;
            this.ClientNameTB.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.Controls.Add(this.FioClientTB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectClientBT, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FioClientTB
            // 
            this.FioClientTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FioClientTB.Location = new System.Drawing.Point(3, 3);
            this.FioClientTB.Name = "FioClientTB";
            this.FioClientTB.ReadOnly = true;
            this.FioClientTB.Size = new System.Drawing.Size(391, 26);
            this.FioClientTB.TabIndex = 0;
            // 
            // SelectClientBT
            // 
            this.SelectClientBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectClientBT.Location = new System.Drawing.Point(400, 3);
            this.SelectClientBT.Name = "SelectClientBT";
            this.SelectClientBT.Size = new System.Drawing.Size(144, 26);
            this.SelectClientBT.TabIndex = 1;
            this.SelectClientBT.Text = "Выбрать";
            this.SelectClientBT.UseVisualStyleBackColor = true;
            this.SelectClientBT.Click += new System.EventHandler(this.SelectClientBT_Click);
            // 
            // SubClientNameTB
            // 
            this.SubClientNameTB.Controls.Add(this.tableLayoutPanel2);
            this.SubClientNameTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubClientNameTB.Location = new System.Drawing.Point(10, 81);
            this.SubClientNameTB.Name = "SubClientNameTB";
            this.SubClientNameTB.Padding = new System.Windows.Forms.Padding(10);
            this.SubClientNameTB.Size = new System.Drawing.Size(567, 71);
            this.SubClientNameTB.TabIndex = 61;
            this.SubClientNameTB.TabStop = false;
            this.SubClientNameTB.Text = "groupBox2";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.Controls.Add(this.SelectSubClientBT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FIOsubClientTB, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SelectSubClientBT
            // 
            this.SelectSubClientBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectSubClientBT.Location = new System.Drawing.Point(400, 3);
            this.SelectSubClientBT.Name = "SelectSubClientBT";
            this.SelectSubClientBT.Size = new System.Drawing.Size(144, 26);
            this.SelectSubClientBT.TabIndex = 2;
            this.SelectSubClientBT.Text = "Выбрать";
            this.SelectSubClientBT.UseVisualStyleBackColor = true;
            this.SelectSubClientBT.Click += new System.EventHandler(this.SelectSubClientBT_Click);
            // 
            // FIOsubClientTB
            // 
            this.FIOsubClientTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FIOsubClientTB.Location = new System.Drawing.Point(3, 3);
            this.FIOsubClientTB.Name = "FIOsubClientTB";
            this.FIOsubClientTB.ReadOnly = true;
            this.FIOsubClientTB.Size = new System.Drawing.Size(391, 26);
            this.FIOsubClientTB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoteTB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(567, 192);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дополнительная информация";
            // 
            // NoteTB
            // 
            this.NoteTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTB.Location = new System.Drawing.Point(10, 29);
            this.NoteTB.Multiline = true;
            this.NoteTB.Name = "NoteTB";
            this.NoteTB.Size = new System.Drawing.Size(547, 153);
            this.NoteTB.TabIndex = 0;
            // 
            // RedListAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubClientNameTB);
            this.Controls.Add(this.ClientNameTB);
            this.Controls.Add(this.panel9);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RedListAccess";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Карточка списка ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RedListAccess_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RedListAccess_FormClosed);
            this.panel9.ResumeLayout(false);
            this.ClientNameTB.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SubClientNameTB.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.GroupBox ClientNameTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox FioClientTB;
        private System.Windows.Forms.GroupBox SubClientNameTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox FIOsubClientTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NoteTB;
        private System.Windows.Forms.Button SelectClientBT;
        private System.Windows.Forms.Button SelectSubClientBT;
    }
}