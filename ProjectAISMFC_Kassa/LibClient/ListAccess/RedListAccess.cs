using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCategory;
using LibClient;

namespace ListAccess
{
    public partial class RedListAccess : Form
    {
        
        clCateegory cat;
        clListAccess list = new clListAccess();
        public RedListAccess(clListAccess lis)
        {
            InitializeComponent();
            cat = new clCateegory(lis.id_Cat);
            list = lis;
            //cat.TypeClient
            ClientNameTB.Text = cat.NameClient;
            SubClientNameTB.Text = cat.NameSubClient;
            if (list.id_Client != null)
            {
                clClient cli = new clClient(list.id_Client);
                list.id_Client = cli.id;
                FioClientTB.Text = cli.lasname + ' ' + cli.firstname + ' ' + cli.middlename;
            }
            if (list.id_SubClient != null)
            {
                clClient cli = new clClient(list.id_SubClient);
                list.id_SubClient = cli.id;
                FIOsubClientTB.Text = cli.lasname + ' ' + cli.firstname + ' ' + cli.middlename;
            }
            NoteTB.Text = list.Note;
        }

        public clListAccess GetData() { return list; }

        private void SelectClientBT_Click(object sender, EventArgs e)
        {
            clClient cli = new clClient();
            cli = clClient.GetSearchClient(cat.TypeClient);
            list.id_Client = cli.id;
            FioClientTB.Text = cli.lasname + ' ' + cli.firstname + ' ' + cli.middlename;
        }

        private void SelectSubClientBT_Click(object sender, EventArgs e)
        {
            clClient cli = new clClient();
            cli = clClient.GetSearchClient();
            list.id_SubClient = cli.id;
            FIOsubClientTB.Text = cli.lasname + ' ' + cli.firstname + ' ' + cli.middlename;
        }

        private void RedListAccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FioClientTB.Text == "" | FIOsubClientTB.Text == "")
            {
                MessageBox.Show("Имеются, не заполненые поля!");
                e.Cancel = true;
            }
        }

        private void RedListAccess_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            list.Note = NoteTB.Text;
        }
    }
}
