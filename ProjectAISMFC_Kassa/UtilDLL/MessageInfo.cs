using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilDLL
{
    public partial class MessageInfo : Form
    {
        public List<String> Lin;

        public MessageInfo()
        {
            InitializeComponent();

            Lin = new List<string>();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageInfo_Shown(object sender, EventArgs e)
        {
            if (Lin != null & Lin.Count != 0)
            {
                this.TitleMes.Text = Lin[0].ToString();

                for (int i = 1; i <= Lin.Count - 1; i++)
                {
                    Info.AppendText(Lin[i] + "\r\n");
                }
            }
        }
    }
}
