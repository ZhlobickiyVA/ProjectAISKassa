using LibDataFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibDataFile
{
    public partial class FormFileReport : Form
    {
        public FormFileReport()
        {
            InitializeComponent();
            this.ListFile.DataSource = clDataFile.GetListDataFile(clDataFile.ServiceIdClient);
            ListFile.Columns[0].Visible = false;
            ListFile.Columns[1].Width = 200;
            ListFile.Columns[2].Width = 200;
        }

        private void RefreshFileReport_Click(object sender, EventArgs e)
        {
            clDataFile.AddFile(clDataFile.ServiceIdClient);
            this.ListFile.DataSource = clDataFile.GetListDataFile(clDataFile.ServiceIdClient);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clDataFile.DeleteFile(this.ListFile.CurrentRow.Cells[0].Value.ToString());
            this.ListFile.DataSource = clDataFile.GetListDataFile(clDataFile.ServiceIdClient);
        }
    }
}
