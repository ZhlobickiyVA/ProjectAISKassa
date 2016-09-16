using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibClient
{
    public partial class spColumns : Form
    {
        public spColumns()
        {
            InitializeComponent();
            ListCol.DataSource = clColumns.GetListColumns();
            ListCol.Columns[0].Visible = false;
        }

        private void spColumns_Load(object sender, EventArgs e)
        {

        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clColumns.AddColumn();
            ListCol.DataSource = clColumns.GetListColumns();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clColumns.UpdateColumn(ListCol.CurrentRow.Cells[0].Value.ToString());
            ListCol.DataSource = clColumns.GetListColumns();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            clColumns.DeleteColumn(ListCol.CurrentRow.Cells[0].Value.ToString());
            ListCol.DataSource = clColumns.GetListColumns();
        }
    }
}
