namespace LibClient
{
    partial class SearClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearClient));
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListCli = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCli)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SearchTB);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.panel4.Size = new System.Drawing.Size(706, 62);
            this.panel4.TabIndex = 62;
            // 
            // SearchTB
            // 
            this.SearchTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTB.Location = new System.Drawing.Point(10, 30);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(686, 26);
            this.SearchTB.TabIndex = 44;
            this.SearchTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LastNameTB_KeyUp);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(686, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Поиск";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.OkBT);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.CancelBT);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel9.Location = new System.Drawing.Point(0, 406);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.panel9.Size = new System.Drawing.Size(706, 50);
            this.panel9.TabIndex = 63;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::LibClient.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(430, 5);
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
            this.panel10.Location = new System.Drawing.Point(565, 5);
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
            this.CancelBT.Location = new System.Drawing.Point(580, 5);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(111, 40);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListCli);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.groupBox2.Size = new System.Drawing.Size(706, 344);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат поиска";
            // 
            // ListCli
            // 
            this.ListCli.AllowUserToAddRows = false;
            this.ListCli.AllowUserToDeleteRows = false;
            this.ListCli.AllowUserToOrderColumns = true;
            this.ListCli.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListCli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCli.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListCli.Location = new System.Drawing.Point(8, 23);
            this.ListCli.Margin = new System.Windows.Forms.Padding(4);
            this.ListCli.MultiSelect = false;
            this.ListCli.Name = "ListCli";
            this.ListCli.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCli.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.ListCli.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListCli.RowTemplate.ReadOnly = true;
            this.ListCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCli.Size = new System.Drawing.Size(690, 317);
            this.ListCli.TabIndex = 16;
            this.ListCli.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCli_CellContentClick);
            // 
            // SearClient
            // 
            this.AcceptButton = this.OkBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBT;
            this.ClientSize = new System.Drawing.Size(706, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма поиска клиентов";
            this.Load += new System.EventHandler(this.SearClient_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView ListCli;
    }
}