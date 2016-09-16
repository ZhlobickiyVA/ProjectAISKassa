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
    
   

    public partial class FspEmployees : Form
    {
        public FspEmployees(DataView sender)
        {
            InitializeComponent();
            this.ListEmpl.DataSource = sender;
            this.ListEmpl.Columns[0].Visible = false;
        }

        private void spEmployees_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clEmployees.AddEmployees();
            ListEmpl.DataSource = clEmployees.GetListEmployess();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clEmployees.UpdateEmployees(ListEmpl.CurrentRow.Cells[0].Value.ToString());
            ListEmpl.DataSource = clEmployees.GetListEmployess();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            clRole.RunSpRole();
        }

        private void ClearPassword_Click(object sender, EventArgs e)
        {
            clEmployees.ClearPasswordEmployees(ListEmpl.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
