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
using LibReport;
using LibEmployees;


namespace CashLib
{
    public partial class fCloseKas : Form
    {
        bool Bclose = false;
        clKassa Kassa;
        private decimal Rez;

        public bool BClose { get; private set; }

        public fCloseKas(clKassa kas)
        {
            InitializeComponent();
            Kassa = kas;
            FioGLBuhTB.Text = kas.Par.FioGlBuh;
            SoldoBeginTB.Text = kas.SolDoBegin.ToString("C2");
            SummaInKassa.Text = kas.SummaInKassa.ToString("C2");
            Info.Text = "Разделитель дробной части: [ " + CLUtils.GetSep() + " ]";

            EmplKomyCB.DataSource = clEmployees.GetListEmployess(1);
            EmplKomyCB.DisplayMember = "SmallName";
            EmplKomyCB.ValueMember = "id";

            this.OstInKassa.Text = "0,00";

            ListItog.DataSource = kas.GetItogToPrice().DefaultView;
            ListItog.Columns[1].Width = 200;
            
            
            SumTransfer.Text = (kas.SummaInKassa - 0).ToString("F2");

        }

        private void ShowReport_Click(object sender, EventArgs e)
        {
            Bclose = true;
            if (ControlResult())
            {
                
                clReportCloseKassa CKas = new clReportCloseKassa();

                CKas.Parametr.OstatikInKassa = (decimal)Convert.ToDouble(this.OstInKassa.Text);
                CKas.Parametr.KolVoReesstr = Convert.ToInt32(this.KlReestrTB.Text);
                CKas.Parametr.IdEmpl = Kassa.idEmpl;
                CKas.Parametr.idEmplKomy = this.EmplKomyCB.SelectedValue.ToString();
                CKas.Parametr.FioGlBuh = this.FioGLBuhTB.Text;
                CKas.Parametr.SolDoBegin = (Decimal)Kassa.SolDoBegin;
                CKas.Parametr.DateItogClose = Kassa.GetItogToPrice();
                CKas.Parametr.SumInKassa = (Decimal)Kassa.SummaInKassa;
                CKas.Parametr.SummaTransfer = Convert.ToDecimal(this.SumTransfer.Text.ToString());
                CKas.GetReportCloseKassa();
                OkBT.Enabled = true;
            }
    }

        private bool ControlResult()
        {
            bool ret = false;



            if (Rez <= clORG.GetMaxSummaInKassa()) ret = true;
            else
            {
                MessageBox.Show("Сальдо на конец дня, превышает возможную Максимальную сумму в кассе! "
                    + clORG.GetMaxSummaInKassa().ToString("C2"));
                
            }
            return ret;
        }

        private void fCloseKas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = BClose;
            
        }

        private void fCloseKas_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            if (ControlResult())
            {
                Kassa.SoldoEnd = Convert.ToDouble(OstInKassa.Text);
                Kassa.Kredit = Convert.ToDouble(SumTransfer.Text);
            }
        }




        private void SumTransfer_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (SumTransfer.Text != "")
                {
                    decimal SumTrDec = Convert.ToDecimal(SumTransfer.Text.ToString());
                    Rez = (Decimal)Kassa.SummaInKassa - SumTrDec;
                    
                    
                        
                        this.OstInKassa.Text = Rez.ToString("F2");
                        //SumTransfer.Text = (kas.SummaInKassa - 0).ToString("F2");
                    
                    
                }
            }
            catch (System.FormatException eroor)
            {
                MessageBox.Show("Не верный формат числа!");
                SumTransfer.Text = SumTransfer.Text.Replace(".", CLUtils.GetSep());
            }
        }
    }
}
