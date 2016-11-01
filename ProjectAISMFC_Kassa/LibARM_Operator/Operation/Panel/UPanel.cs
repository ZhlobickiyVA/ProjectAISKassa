using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnectLib;
using LibEmployees;
using System.Data.SqlClient;
using LibTickets;
using LibClient;
using libCategory;

namespace LibARM_Operator
{
    public partial class UPanel : UserControl
    {
        clPriceControlOperation Oper;
        
        public string idParentMonth { get; set; }
        public string IdEmpl { get; set; }
        public string idCategor { get; set; }

        string Status { get { return StatLab.Text; } set { StatLab.Text = value; } }

        public int TypeTik { get; set; }

        string NameClient
        { get { return ParentPanel.Text; }
            set
            {
                if (DopNameClient != "") ParentPanel.Text = value + " - " + DopNameClient;
                else ParentPanel.Text = value;
            }
        }
        public string Year { get { return YearLab.Text; } set { YearLab.Text = value; } }

        string DopNameClient { get; set; } = "";
        public Double Price { get; set; }

        public DataTable DataMonth { get; set; }
        public DataTable DataSeria { get; set; }
        public DataTable DataNumber { get; set; }


        public int ValidControl { get; set; }

        
        public clClient Client { get; set; }

        // Конструктор
        public UPanel(clPriceControlOperation Operation)
        {
            InitializeComponent();
            this.Oper = Operation;

            DataMonth = new DataTable();
                DataMonth.Columns.Add("id");
                DataMonth.Columns.Add("Name");
            DataSeria = new DataTable();
                DataSeria.Columns.Add("id");
                DataSeria.Columns.Add("Name");
            DataNumber = new DataTable();
                DataNumber.Columns.Add("id");
                DataNumber.Columns.Add("Name");




        }

        public void LoadUPanel()
        {
            
            
            
            ValidControl = -1;
            // 1- Продажа
            // 11 - Продажа сопровождающий
            // 12 - Продажа по категории
            // 2 - Дубликат
            // 3 - Испорчен
            ResreshTypeTik();
            NameClient = Client.GetSmallNameClient();
            this.Price = Oper.Category.Price;
            PriceLab.Text = Price.ToString("C2");
            Year = DateTime.Now.Year.ToString();
            ValidControl = -1;

            MonthCB.DataSource = DataMonth.DefaultView;
            MonthCB.DisplayMember = "Name";
            MonthCB.ValueMember = "id";
            SeriaCB.DataSource = DataSeria.DefaultView;
            SeriaCB.DisplayMember = "Name";
            SeriaCB.ValueMember = "id";
            NumberCB.DataSource = DataNumber.DefaultView;
            NumberCB.DisplayMember = "Name";
            NumberCB.ValueMember = "id";

            if (TypeTik == 2)
            {
                if (idParentMonth != "")
                {
                    MonthCB.BeginUpdate();
                    for (int i = 0; i <= MonthCB.Items.Count - 1; i++)
                    {
                        MonthCB.SelectedIndex = i;
                        if (MonthCB.SelectedValue.ToString() == idParentMonth) break;
                    }
                    MonthCB.EndUpdate();
                }
                
            }
            RefreshSeria();
            ColorLabel.BackColor = clSeries.GetColorToID(SeriaCB.SelectedValue.ToString());


        }
        public void ResreshTypeTik()
        {
            
            switch (this.TypeTik)
            {
                case 1: this.Status = "Продажа"; break;
                case 11: this.Status = "Продажа"; this.DopNameClient = "Сопровождающий"; break;
                case 12: this.Status = "Продажа"; if (Oper.Category != null) this.DopNameClient = Oper.Category.NameSubClient.ToString(); break;
                case 2: this.Status = "Дубликат"; this.Price = 0.00; this.PriceLab.Text = this.Price.ToString("C2"); this.MonthCB.Enabled = false; break;
                case 3: this.Status = "Испорчен"; this.Price = 0.00;this.PriceLab.Text = this.Price.ToString("C2"); break;
                default: this.Status = "Без статуса"; break;
            }


            

            if (ValidControl == -1) { ColorLabel.Text = ""; }
            if (ValidControl == 0) { ColorLabel.Text = "Успех"; ColorLabel.ForeColor = Color.Green; }
            if (ValidControl == 1) { ColorLabel.Text = "Ошибка"; ColorLabel.ForeColor = Color.DarkRed; }
            if (ValidControl == 2) { ColorLabel.Text = "Пропуск"; ColorLabel.ForeColor = Color.DarkRed; }
        }
        private void BrakButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Price = 0;
            if (this.TypeTik != 2) Oper.GetPriceTikToFsender(this.Client, this.TypeTik);
            else
            {
                Oper.GetPriceTikToFsender(this.Client, this.TypeTik,MonthCB.SelectedValue.ToString());
            }
            this.TypeTik = 3;
            this.ResreshTypeTik();
            Oper.ReNumberTicketsToControl();
            
        }

        void RefreshMonth()
        {
            try
            {
                int indexMon = Convert.ToInt32(MonthCB.SelectedValue.ToString());
                SeriaCB.DataSource = Oper.GetListSeria(indexMon);

                for (int i = 0; i <= Oper.FSender.Controls.Count - 1; i++)
                {
                    if (Oper.FSender.Controls[i] is UPanel)
                        if ((Oper.FSender.Controls[i] as UPanel).TypeTik != 3)
                            (Oper.FSender.Controls[i] as UPanel).MonthCB.SelectedIndex = MonthCB.SelectedIndex;
                }
                Oper.ReNumberTicketsToControl();
            }
            catch { }
        }

        void RefreshSeria()
        {
            int indexMon = Convert.ToInt32(MonthCB.SelectedValue.ToString());
            string indexSeria = SeriaCB.SelectedValue.ToString();
            NumberCB.DataSource = Oper.GetListNumber(indexMon, indexSeria);
            try
            {
                ColorLabel.BackColor = clSeries.GetColorToID(indexSeria);
                Oper.ReNumberTicketsToControl();
            }
            catch { }
        }


        private void MonthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMonth();
            DateTime dat = Connect.GetDateServer();
            if (dat.Month == 12 && MonthCB.ValueMember.ToString() == "1")
            {
                int Ye = Convert.ToInt32(this.Year);
                Ye++;
                this.Year = Ye.ToString();
            }
        }
        private void SeriaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSeria();
        }



        private void NumberCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
