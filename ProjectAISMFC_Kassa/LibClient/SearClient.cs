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
    public partial class SearClient : Form
    {
        clClient cli;
        int typecl;
        public SearClient(int typeclient)
        {
            InitializeComponent();
            cli = new clClient();
            typecl = typeclient;
            ListCli.DataSource = clClient.GetListClient("", typecl);
            clClient.ActiveStyleDataGridViewToClient(ListCli);
            for (int i = 0; i <= ListCli.Columns.Count - 1; i++) ListCli.Columns[i].Visible = false;
            ListCli.Columns[1].Visible = true;
            ListCli.Columns[1].Width = 400;

            if (typeclient == 1)
            {
                ListCli.Columns[1].Width = 100;
                ListCli.Columns[1].Visible = true;
                ListCli.Columns[2].Visible = true;
                ListCli.Columns[3].Visible = true;
                ListCli.Columns[4].Visible = true;
                
            }

        }

        private void SearClient_Load(object sender, EventArgs e)
        {

        }

        public clClient GetData() { return cli; }

        private void LastNameTB_KeyUp(object sender, KeyEventArgs e)
        {
            ListCli.DataSource = clClient.GetListClient(SearchTB.Text,typecl);
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
             cli = new clClient(ListCli.CurrentRow.Cells[0].Value.ToString()); 
        }

        private void ListCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cli = new clClient(ListCli.CurrentRow.Cells[0].Value.ToString());
            DialogResult = DialogResult.OK;
        }
    }
}
