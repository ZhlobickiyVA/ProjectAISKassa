using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LibEmployees
{
    public partial class spRole : Form
    {
        public spRole(DataView sender)
        {
            InitializeComponent();
            ListRole.DataSource = sender;
            ListRole.Columns[0].Visible = false;
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spRole_Load(object sender, EventArgs e)
        {


        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clRole.RoleAdd();
            ListRole.DataSource = clRole.GetListRole();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clRole.RoleUpdate(ListRole.CurrentRow.Cells[0].Value.ToString());
            ListRole.DataSource = clRole.GetListRole();
        }
    }
}
