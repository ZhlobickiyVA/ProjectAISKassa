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
using ListAccess;
using LibEmployees;

namespace LibARM_Operator
{
    public partial class FsettingPrice : Form
    {
        clPriceControlOperation Oper;
        public FsettingPrice(clPriceControlOperation Operation)
        {
            InitializeComponent();
            Oper = Operation;
            // Дополнительный билет
            
            if (Operation.Category.AccesDoubTik)
            {
                DoubTikPan.Visible = true;
                ListTikPan.Visible = false;
                this.Height = 170;
                
            }
            // Список дополнительных билетов
            if (Operation.Category.flag)
            {
                DoubTikPan.Visible = false;
                ListTikPan.Visible = true;

            }
        }





        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            while (Oper.ListClient.Count != 1) Oper.ListClient.RemoveAt(Oper.ListClient.Count-1);
            if (Oper.Category.flag)
            for (int i = 0; i <= ListSubCli.Items.Count - 1; i++)
            {
                ListViewItem it = new ListViewItem();
                it = ListSubCli.Items[i];
                clClient Cli = new clClient(it.Tag.ToString());
                Cli.TagTypeClient = 2;
                if (it.Checked) Oper.ListClient.Add(Cli);
            }
            Oper.AccessDoubTikResult = DoubCB.Checked;
            if (Oper.Category.AccesDoubTik && Oper.AccessDoubTikResult)
            {
                
                clClient Cli = new clClient(Oper.ListClient[0].id);
                Cli.TagTypeClient = 3;
                Oper.ListClient.Add(Cli);
            }

            
            
        }

        private void FsettingPrice_Shown(object sender, EventArgs e)
        {
            DoubCB.Checked = Oper.AccessDoubTikResult;

            if (Oper.Category.flag && Oper.Category.TypeClient == 1)
            {
                ListSubCli.Items.Clear();
                DataTable dat = new DataTable();
                dat = Oper.GetSubClientToClient();
                for (int i = 0; i <= dat.Rows.Count - 1; i++)
                {
                    clClient Client = new clClient(dat.Rows[i].ItemArray[2].ToString());
                    ListViewItem it = new ListViewItem();
                    it.Tag = Client.id;
                    it.Text = Client.GetSmallNameClient();
                    if (Oper.ListClient.Count > 0)
                    {
                        for (int j = 0; j <= Oper.ListClient.Count - 1; j++)
                        {
                            if (Client.id == Oper.ListClient[j].id) it.Checked = true;
                        }

                    }



                        this.ListSubCli.Items.Add(it);
                }

                

            }
        }

// Upanel Control Event













    }
}
