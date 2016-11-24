using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibEmployees;
using System.Collections;
using LibARM_Operator;
using libCategory;
using LibClient;
using ListAccess;
using LibTickets;
using CashLib;
using UtilDLL;
using ConnectLib;

namespace LibARM_Operator
{
    public partial class Price : Form
    {
        // Свойства Формы
        //
        clEmployees Empl;
        clCateegory Cat;
        clPriceControlOperation Operation;
        clClient CliZero = new clClient();

        public Price(clEmployees empl,clPriceControlOperation Oper)
        {
            InitializeComponent();
            Empl = empl;
            Operation = Oper;
            // передаем ссылки на графические элементы управления
            Operation.ListCategory = this.ListCat;
            Operation.ButtonSetting = this.SettingPriceBT;
            Operation.FSender = this.FSender;
            Operation.SummaPrice = this.SumPrice;
            Operation.ControlLabel = this.controllabel;
            CliZero = Operation.ListClient[0];
        }

        void RefreshData()
        {
            // Загружаем список категорий по клиенту
            ListCat.BeginUpdate();
            ListCat.Items.Clear();
            for (int i = 0; i <= CliZero.ListCategory.Count - 1; i++)
            {
                Cat = new clCateegory(CliZero.ListCategory[i]);
                ListCat.Items.Add(Cat.Name + " " + Cat.Price.ToString("C2"));
            }
            ListCat.EndUpdate();
            // выбираем первую категорию
            ListCat.SelectedIndex = 0;
        }

        private void Price_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void SetPrice_KeyUp(object sender, KeyEventArgs e)
        {
            double SumPr = Convert.ToDouble(SumPrice.Tag.ToString());
            double SetPr = Convert.ToDouble(SetPrice.Value.ToString());
            double Sum = SumPr - SetPr;
            Sum = Math.Abs(Sum);
            if (SumPr <= SetPr)
            { OutPrice.Text = Sum.ToString("C2"); OutPrice.Tag = 1; }
            else { OutPrice.Text = "Недостаточно!"; OutPrice.Tag = 0; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation.PriceTik();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}




