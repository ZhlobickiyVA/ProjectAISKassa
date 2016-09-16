using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibTickets
{
    public partial class spSeries : Form
    {
 
        public spSeries()
        {
            InitializeComponent();
            this.ListSer.DataSource = clSeries.GetListSeria();
            ListSer.Columns[0].Visible = false;
            
        }

        private void spSeries_Load(object sender, EventArgs e)
        {
            clSeries.RepaintCellgrid(ListSer, 3, 2);
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clSeries.AddSeria();
            this.ListSer.DataSource = clSeries.GetListSeria();
            clSeries.RepaintCellgrid(ListSer, 3, 2);
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clSeries.UpdateSeria(ListSer.CurrentRow.Cells[0].Value.ToString());
            this.ListSer.DataSource = clSeries.GetListSeria();
            clSeries.RepaintCellgrid(ListSer, 3, 2);
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
