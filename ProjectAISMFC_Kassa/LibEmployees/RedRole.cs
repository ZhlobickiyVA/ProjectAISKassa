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
    public partial class RedRole : Form
    {
        clRole role;

        public RedRole()
        {
            InitializeComponent();

            role = new clRole();
        }

        public RedRole(string id)
        {
            InitializeComponent();
            role = new clRole(id);
            role.id = id;
            NameRoleTB.Text = role.Name;
            ListApp.SelectedIndex = role.Level;
            ListApp.SetItemChecked(role.Level, true);
        }


        private void RedRole_Load(object sender, EventArgs e)
        {
            
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            role.Name = NameRoleTB.Text;
            role.Level = ListApp.SelectedIndex;
        }

        public clRole GetData() { return role; }
    }
}
