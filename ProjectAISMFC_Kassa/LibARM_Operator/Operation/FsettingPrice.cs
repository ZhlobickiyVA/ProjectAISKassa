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

namespace LibARM_Operator
{
    public partial class FsettingPrice : Form
    {
        clSettingPrice set;
        DataTable ListAccessToClient = new DataTable();

        public clSettingPrice GetData() { return set; }


        public FsettingPrice(string idCat,string idClient)
        {
            InitializeComponent();
            set = new clSettingPrice();
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            set = new clSettingPrice();
            set.DoubTik = DoubCB.Checked;

            set.ListClientAdd.Clear();

            if (ListTikPan.Visible)
            {
                for (int i = 0; i <= ListSubCli.Items.Count - 1; i++)
                {
                    if (ListSubCli.Items[i].Checked)
                        set.ListClientAdd.Add(ListSubCli.Items[i].SubItems[1].Text);
                }
            }
            
        }

        private void FsettingPrice_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
