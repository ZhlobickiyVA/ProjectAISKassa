using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnectLib;
using UtilDLL;

namespace LibClient
{
    public partial class spDepartment : Form
    {
        public spDepartment()
        {
            InitializeComponent();
            this.ListDep.DataSource = clDepartment.GetListDepart();
            ListDep.Columns[0].Visible = false;
            ListDep.Columns[1].Width = 500;
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clDepartment.AddDepartment();
            this.ListDep.DataSource = clDepartment.GetListDepart();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clDepartment.UpdateDepartment(ListDep.CurrentRow.Cells[0].Value.ToString());
            this.ListDep.DataSource = clDepartment.GetListDepart();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            clDepartment.DeleteDepartment(ListDep.CurrentRow.Cells[0].Value.ToString());
            this.ListDep.DataSource = clDepartment.GetListDepart();
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
