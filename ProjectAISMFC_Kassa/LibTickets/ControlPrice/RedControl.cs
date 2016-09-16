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
    

    public partial class RedControl : Form
    {
        clControlSer con;

        public RedControl()
        {
            InitializeComponent();
            con = new clControlSer();
            SeriesCB.DataSource = clSeries.GetListSeriesFromGroup("0", 0);
            SeriesCB.DisplayMember = "name";
            SeriesCB.ValueMember = "id";
            SeriesCB.SelectedIndex = 1; SeriesCB.SelectedIndex = 0;
            MonthCB.SelectedIndex = 0;
        }

        public RedControl(string id)
        {
            InitializeComponent();
            con = new clControlSer(id);
            SeriesCB.DataSource = clSeries.GetListSeriesFromGroup("0", 0);
            SeriesCB.DisplayMember = "name";
            SeriesCB.ValueMember = "id";
            MonthCB.SelectedIndex = 0;
            SeriesCB.SelectedIndex = 1; SeriesCB.SelectedIndex = 0;
            for (int i = 0; i <= SeriesCB.Items.Count - 1; i++)
            {
                SeriesCB.SelectedIndex = i;
                if (con.id_Series.ToString() == SeriesCB.SelectedValue.ToString()) break;
            }
            
            ActiveCB.Checked = con.Active;
            this.DateB.Value = con.BeginDate.Date;
            this.DateE.Value = con.EndDate.Date;
            this.MonthCB.SelectedIndex = con.Mon-1;

        }

        private void RedControl_Load(object sender, EventArgs e)
        {

        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            con.id_Series = this.SeriesCB.SelectedValue.ToString();
            con.Active = ActiveCB.Checked;
            con.BeginDate = this.DateB.Value.Date;
            con.EndDate = this.DateE.Value.Date;
            con.Mon = this.MonthCB.SelectedIndex + 1;
        }

        public clControlSer GetData() { return con; }
    }
}
