using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibEmployees
{
    public partial class spRedOrg : Form
    {
        clORG org = new clORG();
        bool flag = false;
        public spRedOrg()
        {
            InitializeComponent();
            this.NameORG.Text = org.Name.Trim();
            this.slName.Text = org.slName.Trim();
            this.Phone.Text = org.Phone.Trim();
            this.DocKom.Text = org.DocOsnCom.Trim();
            this.PredDolzh.Text = org.PredComDolzh.Trim();
            this.PredFio.Text = org.PredComFio.Trim();
            this.cl1Dolzh.Text = org.cl1ComDolzh.Trim();
            this.cl1Fio.Text = org.cl1ComFIo.Trim();

            this.cl2Dolzh.Text = org.cl2ComDolzh.Trim();
            this.cl2Fio.Text = org.cl2ComFIo.Trim();

            this.cl3Dolzh.Text = org.cl3ComDolzh.Trim();
            this.cl3Fio.Text = org.cl3ComFIo.Trim();

            this.DirectName.Text = org.Director.Trim();

            this.MaxSumInKassa.Text = org.MaxSumInKassa.ToString("F2");
        }

        public clORG Getdata() { return org; }
       
        private void OkBT_Click(object sender, EventArgs e)
        {
            org.Name = this.NameORG.Text;
            org.slName = this.slName.Text;
            org.Phone = this.Phone.Text;
            org.DocOsnCom = this.DocKom.Text;
            org.PredComDolzh = this.PredDolzh.Text;
            org.PredComFio = this.PredFio.Text;
            org.cl1ComDolzh = this.cl1Dolzh.Text;
            org.cl1ComFIo = this.cl1Fio.Text;
            org.cl2ComDolzh = this.cl2Dolzh.Text;
            org.cl2ComFIo = this.cl2Fio.Text;
            org.cl3ComDolzh = this.cl3Dolzh.Text;
            org.cl3ComFIo = this.cl3Fio.Text;
            org.Director = this.DirectName.Text;
            try
            {
                org.MaxSumInKassa = Convert.ToDecimal(this.MaxSumInKassa.Text.ToString());
            }
            catch
            {
                flag = true;
            }

        }

        private void spRedOrg_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = flag;
        }
    }
}
