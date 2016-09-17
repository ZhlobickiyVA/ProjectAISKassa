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

namespace LibARM_Operator
{
    public partial class Price : Form
    {

        clEmployees Empl;
        clClient Cli;
        clCateegory Cat;
        string IdSelectedCat;
        clOperation Operation;
        FsettingPrice FormSetting;

        clSettingPrice Setting = new clSettingPrice();
        
        DataTable ListAccessToClient = new DataTable();
        

        public Price(clEmployees empl,clClient cli)
        {
            InitializeComponent();
            Empl = empl;
            Cli = cli;
            LoadTicketsDataToEmpl();
            RefreshData();
            
            FormSetting = new FsettingPrice(Cat.id, Cli.id);
            this.Text += " ... Клиент: " + cli.GetSmallNameClient(); 
            

        }
        // Загружаем массив возможных билетов для сотрудника для данной продажи
        private void LoadTicketsDataToEmpl()
        {
            // Появился список месяцев
            Operation = new clOperation(Empl.id);
        }

        // ---------------- Обновление данных ------------------------------
        void RefreshData()
        {
            // загрузили список доверенностей по клиенту
            ListDov.Items.Clear();
            ListDov.DataSource = clWarrant.GetListWarrant(Cli.id);
            ListDov.DisplayMember = "SmallName";
            ListDov.ValueMember = "id";
            // Загружаем список категорий по клиенту
            ListCat.Items.Clear();
            for (int i = 0; i <= Cli.ListCategory.Count - 1; i++)
            {
                Cat = new clCateegory(Cli.ListCategory[i]);
                ListCat.Items.Add(Cat.Name+" "+Cat.Price.ToString("C2"));
            }
            // выбираем первую категорию
            ListCat.SelectedIndex = 0;
        }

//----------------Отображение билета --------------------------------------------------
        void GetPriceTikToFsender(string IdClient,int Type = 1)
        {
            UPanel Pan = new UPanel();
            Pan.IdClient = IdClient;
            Pan.idCategor = Cat.id;
            Pan.IdEmpl = Empl.id;
            Pan.TypeTik =  Type;
            Pan.MonthCB.DataSource = Operation.DataMonth.DefaultView;
            Pan.MonthCB.DisplayMember = "Name";
            Pan.MonthCB.ValueMember = "id";
            Pan.MonthCB.SelectedIndex = 0;
            Pan.OnDataSeria += Operation.GetDefaultSeria;
            Pan.OnDataNumber += Operation.GetDefaultNumber;
            Pan.LoadUPanel();

            Pan.OnDataSeria -= Operation.GetDefaultSeria;
            Pan.OnDataNumber -= Operation.GetDefaultNumber;
            Pan.OnDataSeria += Operation.GetSeriaToPrice;
            Pan.OnDataNumber += Operation.GetNumberTikToPrice;
            FSender.Controls.Add(Pan);
        }
// --------------------Информационный билет------------------------------------------------
        public void GetPanelInfoToSender(clListAccess lis)
        {
            FSender.Controls.Add(new UpanelService(lis));
        }

// ---------------------------------------------------------------------
        private void OpenClient_Click(object sender, EventArgs e)
        {
            clClient.OpenClient(Cli.id);
        }

        private void AddWar2_Click(object sender, EventArgs e)
        {
            clWarrant.AddWarrant(Cli);
        }

        private void ListCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting = new clSettingPrice();

            FSender.Controls.Clear();

            IdSelectedCat = Cli.ListCategory[ListCat.SelectedIndex].ToString();
            Cat = new clCateegory(IdSelectedCat);
            infocat.Text = Cat.Note;
            
            if (Cat.flag)
            {                
                clListAccess lis = new clListAccess();
                lis.id_Cat = Cat.id;
                lis.Month = DateTime.Now.Month;
                lis.Year = DateTime.Now.Year;
                if (Cat.TypeClient == 1)
                {
                    lis.id_Client = Cli.id;
                    ListAccessToClient = clListAccess.GetListAccess(lis, 1);
                    FormSetting.ListSubCli.Items.Clear();
                    for (int i = 0; i <= ListAccessToClient.Rows.Count - 1; i++)
                    {
                        clClient scli = new clClient(ListAccessToClient.Rows[i].ItemArray[2].ToString());
                        ListViewItem It = new ListViewItem();
                        It.Text = scli.GetSmallNameClient();
                        It.SubItems.Add(scli.id);
                        for (int j = 0; j <= Setting.ListClientAdd.Count-1; j++)
                        {
                            if (It.SubItems[0].Text == Setting.ListClientAdd[j].ToString())
                            {
                                It.Checked = true;
                            }

                        }
                        FormSetting.ListSubCli.Items.Add(It);
                    }

                }
                if (Cat.TypeClient == 2) 
                {
                    lis.id_SubClient = Cli.id;
                    ListAccessToClient = clListAccess.GetListAccess(lis, 2);
                }  
                // Проверяем наличие в списке клиента если нет отображаем форму инфо         
                if ( ListAccessToClient.Rows.Count !=0)
                {
                    GetPriceTikToFsender(Cli.id);
                }
                else
                {
                    GetPanelInfoToSender(lis);
                    SettingPrice.Enabled = false;
                }
            }
            else GetPriceTikToFsender(Cli.id);

            if (Cat.flag || Cat.AccesDoubTik)
            {
                SettingPrice.Enabled = true;
            }
            else SettingPrice.Enabled = false;

        }

        private void SettingPrice_Click(object sender, EventArgs e)
        {
            if (Cat.flag)
            {
               FormSetting.DoubTikPan.Visible = false;
               FormSetting.ListTikPan.Visible = true;
                FormSetting.ListTikPan.Dock = DockStyle.Fill;
            }

            if (Cat.AccesDoubTik)
            {
                //DoubCB.Checked = DefaultSetting.DoubTik;
                FormSetting.DoubTikPan.Visible = true;
                FormSetting.ListTikPan.Visible = false;
            }


            if (FormSetting.ShowDialog() == DialogResult.OK)
            {
                Setting = FormSetting.GetData();
                // TODO: Переписать алгоритм удаления билетов
                while (FSender.Controls.Count!=1) { FSender.Controls.Remove(FSender.Controls[FSender.Controls.Count-1]); }

                if (Setting.DoubTik)
                    {
                        GetPriceTikToFsender(Cli.id,11);
                    }
                    for (int i = 0; i <= Setting.ListClientAdd.Count - 1; i++)
                    {
                        GetPriceTikToFsender(Setting.ListClientAdd[i].ToString(),12);
                    }                
            }


        }

        private void Price_Shown(object sender, EventArgs e)
        {

        }

        private void OpenListAccess_Click(object sender, EventArgs e)
        {
            clListAccess.RunListAccess();
        }

        private void FSender_ControlAdded(object sender, ControlEventArgs e)
        {
            double SummaPrice = 0;
            
            for (int i = 0; i <= FSender.Controls.Count - 1; i++)
            {
                SummaPrice += (FSender.Controls[i] as UPanel).Price;
                
            }
            this.SumPrice.Text = SummaPrice.ToString("C2");
            this.SumPrice.Tag = SummaPrice;

        }

        private void SetPrice_KeyUp(object sender, KeyEventArgs e)
        {
                OutPrice.Text = (Convert.ToDouble(SetPrice.Value) - Convert.ToDouble(SumPrice.Tag)).ToString("C2");          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Operation.GetControlPrice(FSender, controllabel))
            {
                if (MessageBox.Show("Проверка пройденна!", "Вы уверенны, что хотите выполнить операцию?"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    clKassa Kas = new clKassa();
                    clEventTickets Event = new clEventTickets();
                    Event.id_Empl = Empl.id;
                    Event.Id_CategoryOper = Cat.id;
                    

                    for (int i = 0; i <= FSender.Controls.Count - 1; i++)
                    {
                        UPanel Pan = (FSender.Controls[i] as UPanel);
                        if (Pan.TypeTik != 3)
                        {
                            Event.id_Client = Pan.IdClient;
                            Event.Month = Convert.ToInt32( Pan.MonthCB.SelectedValue.ToString());
                            Event.Year = Convert.ToInt32( Pan.Year);
                            Event.id_Bilet = Pan.NumberCB.SelectedValue.ToString();
                            Event.Price = Pan.Price;
                            Event.NomOper = clFix.GetFix();
                            Event.InsertEvent();
                        }
                        else
                        {
                            // Обработка испорченных билетов
                        }
                    }
                    Kas.NomOper = Event.NomOper;
                    Kas.Debet = (double)this.SumPrice.Tag;
                    Kas.Kredit = 0;
                    Kas.idEmpl = Empl.id;
                    Kas.InsertMoneyToKassa();
                }

            }
        }
    }


}




//Command.Parameters.Add("@Status", SqlDbType.Int);
//            Command.Parameters["@Status"].Value = this.Status;
//            // Продажа
//            if (this.id_Client != null)
//            {


//    Command.Parameters.Add("@nomoper", SqlDbType.Int);
//    Command.Parameters["@nomoper"].Value = this.NomOper;
//}