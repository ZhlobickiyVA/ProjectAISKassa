using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListAccess;

namespace LibARM_Operator
{
    public partial class UpanelService : UserControl
    {
        clListAccess Lis = new clListAccess(); 

        public UpanelService(clListAccess lis)
        {
            InitializeComponent();
            Lis = lis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clListAccess.AddList(Lis);
        }
    }
}
