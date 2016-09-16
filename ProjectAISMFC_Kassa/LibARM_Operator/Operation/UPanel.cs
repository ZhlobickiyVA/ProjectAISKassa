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
    
        
        public string IdClient { get; set; }
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
        public bool BrakTrig { get { return !this.Enabled; } set { this.Enabled = !value; } }



        clCateegory CategoryPrice;
        clEmployees Empl;
        clClient Client;

        // Конструктор
        public UPanel()
        {
            InitializeComponent();

            BrakTrig = false;
        }

        public void LoadUPanel()
        {
            CategoryPrice = new clCateegory(idCategor);
            Empl = new clEmployees(IdEmpl);
            Client = new clClient(IdClient);

            // 1- Продажа
            // 11 - Продажа сопровождающий
            // 12 - Продажа по категории
            // 2 - Дубликат
            // 3 - Испорчен
            ResreshTypeTik();
            NameClient = Client.GetSmallNameClient();
            this.Price = CategoryPrice.Price;
            PriceLab.Text = Price.ToString("C2");
            Year = DateTime.Now.Year.ToString();
            
        }
        void ResreshTypeTik()
        {
            
            switch (this.TypeTik)
            {
                case 1: this.Status = "Продажа"; break;
                case 11: this.Status = "Продажа"; this.DopNameClient = "Сопровождающий"; break;
                case 12: this.Status = "Продажа"; if (CategoryPrice != null) this.DopNameClient = CategoryPrice.NameSubClient.ToString(); break;
                case 2: this.Status = "Дубликат"; this.Price = 0.00; this.PriceLab.Text = this.Price.ToString("C2"); break;
                case 3: this.Status = "Испорчен"; this.Price = 0.00;this.PriceLab.Text = this.Price.ToString("C2"); break;
                default: this.Status = "Без статуса"; break;
            }
        }



        private void BrakButton_Click(object sender, EventArgs e)
        {
            this.TypeTik = 3;
            ResreshTypeTik();
            BrakTrig = !BrakTrig;

            UPanel Pan = new UPanel();
            Pan.IdClient = IdClient;
            Pan.idCategor = idCategor;
            Pan.IdEmpl = IdEmpl;
            Pan.TypeTik = this.TypeTik;
            Pan.LoadUPanel();
            Pan.Parent = this.Parent;

        }

        private void MonthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = this.MonthCB.SelectedIndex;
                for (int i = 0; i <= this.Parent.Controls.Count - 1; i++)
                {
                    (this.Parent.Controls[i] as UPanel).MonthCB.SelectedIndex = index;
                }
            }
            catch { }
            
            


            //try
            //{
            //    ColorTik.BackColor = clSeries.getColorFromChar(clSeries.GetColorToName(SeriaCB.SelectedText.ToString()));
            //}
            //catch { MessageBox.Show("Не могу получить Цвет!"); }
        }


    }
}
