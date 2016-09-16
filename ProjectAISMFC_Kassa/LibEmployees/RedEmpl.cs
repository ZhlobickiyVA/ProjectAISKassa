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
    public partial class FeditSPEmpl : Form
    {
        clEmployees empl;

        public FeditSPEmpl()
        {
            InitializeComponent();
            empl = new clEmployees();
        }

        public FeditSPEmpl(string id)
        {
            InitializeComponent();
            empl = new clEmployees(id);
            LastNameTB.Text = empl.LastName;
            FirstNameTB.Text = empl.FirstName;
            MiddleNameTB.Text = empl.MiddleName;
            DateRtp.Value = empl.DateB.Date;
            SpRoleCB.SelectedValue = empl.idRole;
            DocNameTB.Text = empl.DocName;
            DocSerTB.Text = empl.DocSeria;
            DocNumTb.Text = empl.DocNumber;
            DocOrgTB.Text = empl.DocOrg;
            DocRetTP.Value = empl.DocDateRet.Date;
            FlagCB.Checked = empl.Flag;
            DolzhTb.Text = empl.Dolzhost;
            OtdelTB.Text = empl.Otdel;
            PasswordTB.Enabled = false;
        }

        public clEmployees GetData() { return empl; }

        private void OkBT_Click(object sender, EventArgs e)
        {
                       
            empl.LastName = this.LastNameTB.Text;
            empl.FirstName = this.FirstNameTB.Text;
            empl.MiddleName = this.MiddleNameTB.Text;
            empl.DateB = this.DateRtp.Value.Date;
            empl.idRole = this.SpRoleCB.SelectedValue.ToString();
            empl.DocName = this.DocNameTB.Text;
            empl.DocSeria = this.DocSerTB.Text;
            empl.DocNumber = this.DocNumTb.Text;
            empl.DocDateRet = this.DocRetTP.Value.Date;
            empl.DocOrg = this.DocOrgTB.Text;
            empl.Password = this.PasswordTB.Text;
            empl.Flag = this.FlagCB.Checked;
            empl.Dolzhost = this.DolzhTb.Text;
            empl.Otdel = this.OtdelTB.Text;


            Close();
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FeditSPEmpl_Load(object sender, EventArgs e)
        {
            SpRoleCB.DataSource = clRole.GetListRole();
            SpRoleCB.DisplayMember = "Название";
            SpRoleCB.ValueMember = "Id";

            SpRoleCB.BeginUpdate();
            SpRoleCB.SelectedIndex = 1;
            SpRoleCB.SelectedIndex = 0;
            SpRoleCB.EndUpdate();

        }
    }
}
