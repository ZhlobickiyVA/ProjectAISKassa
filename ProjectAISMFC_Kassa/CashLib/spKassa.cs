using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashLib;
using ConnectLib;
using LibEventLog;
using LibReport;

namespace CashLib
{
    public partial class spKassa : Form
    {
        clKassa kassa = new clKassa();
        public spKassa(clKassa kas)
        {
            InitializeComponent();
            kassa = kas;
            
            ListKassa.DataSource = kassa.GetListKassa().DefaultView;
            ListKassa.Columns[0].Visible = false;
            ListKassa.Columns[1].Width = 120;
            ListKassa.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListKassa.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListKassa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListKassa.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            timer.Enabled = true;
        }



        private void spKassa_Shown(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int i = ListKassa.CurrentRow.Index;
            ListKassa.DataSource = kassa.GetListKassa().DefaultView;
            ListKassa.Rows[i].Selected = true;
            ListKassa.CurrentCell = ListKassa[1, i];
            ListKassa.Select();
        }
    }
}
