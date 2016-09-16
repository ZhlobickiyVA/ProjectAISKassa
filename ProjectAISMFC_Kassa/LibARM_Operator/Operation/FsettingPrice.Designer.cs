namespace LibARM_Operator
{
    partial class FsettingPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FsettingPrice));
            this.DoubTikPan = new System.Windows.Forms.GroupBox();
            this.DoubCB = new System.Windows.Forms.CheckBox();
            this.ListTikPan = new System.Windows.Forms.GroupBox();
            this.ListSubCli = new System.Windows.Forms.ListView();
            this.NAme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBT = new System.Windows.Forms.Button();
            this.DoubTikPan.SuspendLayout();
            this.ListTikPan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoubTikPan
            // 
            this.DoubTikPan.AutoSize = true;
            this.DoubTikPan.Controls.Add(this.DoubCB);
            this.DoubTikPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoubTikPan.Location = new System.Drawing.Point(0, 0);
            this.DoubTikPan.Name = "DoubTikPan";
            this.DoubTikPan.Padding = new System.Windows.Forms.Padding(20, 19, 3, 20);
            this.DoubTikPan.Size = new System.Drawing.Size(414, 81);
            this.DoubTikPan.TabIndex = 0;
            this.DoubTikPan.TabStop = false;
            this.DoubTikPan.Text = "Дополнительные параметры";
            // 
            // DoubCB
            // 
            this.DoubCB.AutoSize = true;
            this.DoubCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoubCB.Location = new System.Drawing.Point(20, 38);
            this.DoubCB.Name = "DoubCB";
            this.DoubCB.Size = new System.Drawing.Size(391, 23);
            this.DoubCB.TabIndex = 0;
            this.DoubCB.Text = "Дополнительный билет";
            this.DoubCB.UseVisualStyleBackColor = true;
            // 
            // ListTikPan
            // 
            this.ListTikPan.Controls.Add(this.ListSubCli);
            this.ListTikPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListTikPan.Location = new System.Drawing.Point(0, 81);
            this.ListTikPan.Name = "ListTikPan";
            this.ListTikPan.Padding = new System.Windows.Forms.Padding(5);
            this.ListTikPan.Size = new System.Drawing.Size(414, 233);
            this.ListTikPan.TabIndex = 1;
            this.ListTikPan.TabStop = false;
            this.ListTikPan.Text = "Дополнительные параметры";
            // 
            // ListSubCli
            // 
            this.ListSubCli.CheckBoxes = true;
            this.ListSubCli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NAme});
            this.ListSubCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSubCli.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListSubCli.Location = new System.Drawing.Point(5, 24);
            this.ListSubCli.Name = "ListSubCli";
            this.ListSubCli.ShowGroups = false;
            this.ListSubCli.Size = new System.Drawing.Size(404, 204);
            this.ListSubCli.TabIndex = 0;
            this.ListSubCli.UseCompatibleStateImageBehavior = false;
            this.ListSubCli.View = System.Windows.Forms.View.Details;
            // 
            // NAme
            // 
            this.NAme.Text = "id";
            this.NAme.Width = 400;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OkBT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CancelBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.panel1.Size = new System.Drawing.Size(414, 47);
            this.panel1.TabIndex = 53;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::LibARM_Operator.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(138, 5);
            this.OkBT.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(135, 37);
            this.OkBT.TabIndex = 4;
            this.OkBT.Text = "Сохранить";
            this.OkBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OkBT.UseVisualStyleBackColor = true;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(273, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 37);
            this.panel2.TabIndex = 3;
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBT.Image = global::LibARM_Operator.Properties.Resources.button_cancel_6569;
            this.CancelBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBT.Location = new System.Drawing.Point(288, 5);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(111, 37);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Отмена";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // FsettingPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListTikPan);
            this.Controls.Add(this.DoubTikPan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FsettingPrice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка продажи";
            this.Shown += new System.EventHandler(this.FsettingPrice_Shown);
            this.DoubTikPan.ResumeLayout(false);
            this.DoubTikPan.PerformLayout();
            this.ListTikPan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.ColumnHeader NAme;
        public System.Windows.Forms.CheckBox DoubCB;
        public System.Windows.Forms.ListView ListSubCli;
        public System.Windows.Forms.GroupBox DoubTikPan;
        public System.Windows.Forms.GroupBox ListTikPan;
    }
}