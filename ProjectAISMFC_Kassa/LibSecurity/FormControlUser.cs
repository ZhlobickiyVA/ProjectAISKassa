using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibEmployees;
using System.Reflection;

namespace LibSecurity
{
    public partial class FormControlUser : Form
    {
        
        
        
        public FormControlUser()
        {
            InitializeComponent();
            
            this.ListEmpl.DataSource = clEmployees.GetListEmployess(2).ToTable().DefaultView;
            this.ListEmpl.DisplayMember = "SmallName";
            this.ListEmpl.ValueMember = "id";
                        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormControlUser_Load(object sender, EventArgs e)
        {
            
        }

        private void OkBT_Click(object sender, EventArgs e)
        {

        }

        public bool GetData(out string ide)
        {
            ide = ListEmpl.SelectedValue.ToString();
            return clAut.ValudEmpl(ListEmpl.SelectedValue.ToString(), Password.Text.Trim());
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormControlUser_Shown(object sender, EventArgs e)
        {
            Password.Focus();
        }
    }
}
