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
            clEmployees ListEmplo = new clEmployees();
            ListEmplo.GetListEmployess(this.comboBox1);
                        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormControlUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Tag = 0;

            clAut avtor = new clAut();

            int lev = 0;
            this.comboBox1.Select();
            int ret = avtor.ValudEmpl(this.comboBox1.SelectedValue.ToString(), this.textBox1.Text.ToString(),ref lev);

            

            if (ret == 0) MessageBox.Show("Неверный пароль!");
            else
            {
                this.Tag = lev;
                this.DialogResult = DialogResult.OK;
                Close();


            }

            // select pwdcompare('qwerty', 0x01001A050E12BCCAF8A10EAC067AC1E0963669A213CBD5170177)



        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
