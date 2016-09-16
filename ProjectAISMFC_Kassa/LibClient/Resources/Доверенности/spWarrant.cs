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
    public partial class spWarrant : Form
    {
        
        public spWarrant()
        {
            InitializeComponent();
            ListWar.DataSource = clWarrant.GetListWarrant("");
            ListWar.Columns[0].Visible = false;
            ListWar.Columns[1].Visible = false;
        }

        private void spWarrant_Load(object sender, EventArgs e)
        {

        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clWarrant.AddWarrant();
            ListWar.DataSource = clWarrant.GetListWarrant("");
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clWarrant.UpdateWarrant(ListWar.CurrentRow.Cells[0].Value.ToString());
            ListWar.DataSource = clWarrant.GetListWarrant("");
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            clWarrant.DeleteWarrant(ListWar.CurrentRow.Cells[0].Value.ToString());
            ListWar.DataSource = clWarrant.GetListWarrant("");
        }
    }
}
