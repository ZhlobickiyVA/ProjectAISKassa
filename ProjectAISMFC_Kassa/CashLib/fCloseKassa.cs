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

            this.OstInKassa.Text = kas.SoldoEnd.ToString();

            ListItog.DataSource = kas.GetItogToPrice().DefaultView;
            ListItog.Columns[0].Visible = false;
            ListItog.Columns[1].Width = 200;
            // TODO: Потом убрать
            this.listBox1.Items.Add("Касса открыта:" + kas.SoldoBeginDate.ToShortDateString()+ " Сальдо начало: " + kas.SolDoBegin.ToString("C2"));
            this.listBox1.Items.Add("Касса закрыта:" + kas.SoldoEndDate.ToShortDateString() + " Сальдо конец: " + kas.SoldoEnd.ToString("C2"));


        }

        private void ShowReport_Click(object sender, EventArgs e)
        {
            Bclose = true;
            clReportCloseKassa CKas = new clReportCloseKassa();

            CKas.Parametr.OstatikInKassa = Convert.ToDouble( this.OstInKassa.Text);
            CKas.Parametr.KolVoReesstr = Convert.ToInt32( this.KlReestrTB.Text);
            CKas.Parametr.IdEmpl = Kassa.idEmpl;
            CKas.Parametr.idEmplKomy = this.EmplKomyCB.SelectedValue.ToString();
            CKas.Parametr.FioGlBuh = this.FioGLBuhTB.Text;
            CKas.Parametr.SolDoBegin = (Decimal)Kassa.SolDoBegin;
            CKas.Parametr.DateItogClose = Kassa.GetItogToPrice();
            CKas.GetReportCloseKassa();
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
    }
}
