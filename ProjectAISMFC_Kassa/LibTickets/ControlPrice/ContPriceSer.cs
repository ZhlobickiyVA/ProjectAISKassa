using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibTickets
{
    public partial class ContPriceSer : Form
    {
        public ContPriceSer()
        {
            InitializeComponent();
            this.ListControl.DataSource = clControlSer.GetControlSer();
            this.ListControl.Columns[0].Visible = false;
            this.ListControl.Columns[1].Visible = false;
        }


        private void AddBT_Click(object sender, EventArgs e)
        {
            clControlSer.CreateControlSer();
            this.ListControl.DataSource = clControlSer.GetControlSer();
            clSeries.RepaintCellgrid(this.ListControl, 2, 1);
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clControlSer.UpdateControlSer(this.ListControl.CurrentRow.Cells[0].Value.ToString());
            this.ListControl.DataSource = clControlSer.GetControlSer();
            clSeries.RepaintCellgrid(this.ListControl, 2, 1);
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            clControlSer.DeleteControlSer(this.ListControl.CurrentRow.Cells[0].Value.ToString());
            this.ListControl.DataSource = clControlSer.GetControlSer();
            clSeries.RepaintCellgrid(this.ListControl, 2, 1);
        }

        private void ContPriceSer_Shown(object sender, EventArgs e)
        {
            clSeries.RepaintCellgrid(this.ListControl, 2, 1);
            
        }



        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListControl_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clSeries.RepaintCellgrid(this.ListControl, 2, 1);
        }
    }
}
