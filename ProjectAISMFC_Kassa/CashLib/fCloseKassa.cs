using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibEventLog;
using UtilDLL;


namespace CashLib
{
    public partial class fCloseKas : Form
    {
        
        public fCloseKas(clKassa kas)
        {
            InitializeComponent();
            FioGLBuhTB.Text = kas.Par.FioGlBuh;
            SoldoBeginTB.Text = kas.SolDoBegin.ToString();
            SummaInKassa.Text = kas.SummaInKassa.ToString();
            Info.Text = "Разделитель дробной части: [ " + CLUtils.GetSep() + " ]";
            
        }

        private void ShowReport_Click(object sender, EventArgs e)
        {

        }
    }
}
