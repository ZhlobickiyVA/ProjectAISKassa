using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibEmployees;
using LibTickets;

namespace LibTickets
{
    public partial class RedAddTik : Form
    {
        string idser;
        string idempl;

        public RedAddTik()
        {
            InitializeComponent();
            EmplCB.DataSource = clEmployees.GetListEmployess(1);
            EmplCB.DisplayMember = "SmallName";
            EmplCB.ValueMember = "id";
            SeriesCB.DataSource = clSeries.GetListSeria();
            SeriesCB.DisplayMember = "Название";
            SeriesCB.ValueMember = "ids";
            SeriesCB.SelectedIndex = 1; SeriesCB.SelectedIndex = 0; SeriesCB.Select();
            EmplCB.SelectedIndex = 1;EmplCB.SelectedIndex = 0; EmplCB.Select();
        }

        private void RedAddTik_Load(object sender, EventArgs e)
        {

        }
        private void SeriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            idser = SeriesCB.SelectedValue.ToString();
        }

        private void EmplCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            idempl = EmplCB.SelectedValue.ToString();
        }

        private void AddListTik_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = SeriesCB.Text;
            item.Tag = SeriesCB.SelectedValue.ToString();
            item.SubItems.Add(FromUD.Value.ToString());
            item.SubItems.Add(CountUD.Value.ToString());
            WhereLV.Items.Add(item);
        }

        private void RemoveListTik_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.WhereLV.SelectedItems)
            {
                this.WhereLV.Items.Remove(item);
            }
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= WhereLV.Items.Count - 1; i++)
            {
                clPackTick.CreatePackTik
                (
                    idempl
                    ,WhereLV.Items[i].Tag.ToString()
                    ,Convert.ToInt32(WhereLV.Items[i].SubItems[1].Text)
                    ,Convert.ToInt32(WhereLV.Items[i].SubItems[2].Text)
                );
            }
        }
    }
}
