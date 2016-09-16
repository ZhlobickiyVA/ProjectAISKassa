namespace UtilDLL
{
    partial class MessageInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageInfo));
            this.TitleMes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleMes
            // 
            this.TitleMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleMes.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleMes.ForeColor = System.Drawing.Color.DarkRed;
            this.TitleMes.Location = new System.Drawing.Point(10, 10);
            this.TitleMes.Name = "TitleMes";
            this.TitleMes.Padding = new System.Windows.Forms.Padding(10);
            this.TitleMes.Size = new System.Drawing.Size(346, 72);
            this.TitleMes.TabIndex = 0;
            this.TitleMes.Text = "TitleMes";
            this.TitleMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OkBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 243);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.panel1.Size = new System.Drawing.Size(346, 50);
            this.panel1.TabIndex = 1;
            // 
            // OkBT
            // 
            this.OkBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkBT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Image = global::UtilDLL.Properties.Resources.camera_test_1751;
            this.OkBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBT.Location = new System.Drawing.Point(100, 0);
            this.OkBT.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(146, 50);
            this.OkBT.TabIndex = 5;
            this.OkBT.Text = "   Хорошо";
            this.OkBT.UseVisualStyleBackColor = true;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.Control;
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(10, 82);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Info.Size = new System.Drawing.Size(346, 161);
            this.Info.TabIndex = 2;
            this.Info.Text = "";
            // 
            // MessageInfo
            // 
            this.AcceptButton = this.OkBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 303);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleMes);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MessageInfo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информационное сообшение";
            this.Shown += new System.EventHandler(this.MessageInfo_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleMes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.Button OkBT;
    }
}