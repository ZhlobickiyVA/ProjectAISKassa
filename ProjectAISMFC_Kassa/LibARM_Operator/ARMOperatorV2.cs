using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibEmployees;
using LibClient;
using CashLib;
using System.Data.SqlClient;
using LibTickets;
using ConnectLib;
using ListAccess;

namespace LibARM_Operator
{
    public partial class ARMOperatorV2 : Form
    {
        clEmployees empl;
        clKassa Kas;
        string sea;
        int SelectRow;
        int CountTikEmployees { get; set; }
        
        public ARMOperatorV2(string idEmpl)
        {
            InitializeComponent();
            empl = new clEmployees(idEmpl);
            Kas = new clKassa(idEmpl);
            NameEmpl.Text = clEmployees.GetNameRole(idEmpl) +": "+empl.GetSmallFIO().ToString();
            ListCli.DataSource = clClient.GetListClient("");
            clClient.ActiveStyleDataGridViewToClient(ListCli);
            if (Kas.ActiveKassa == 0)
            {
                OpenKassaItem.Enabled = true;
                CloseKassaItem.Enabled = false;
                PriceTIkBT.Enabled = false;
                DoubTikBT.Enabled = false;
            }
            if (Kas.ActiveKassa == 1)
            {
                OpenKassaItem.Enabled = false;
                CloseKassaItem.Enabled = true;
                PriceTIkBT.Enabled = true;
                DoubTikBT.Enabled = true;
            }
            timer.Enabled = true;
        }

        private void SearchTB_KeyUp(object sender, KeyEventArgs e)
        {
            sea = SearchTB.Text;
            ListCli.DataSource = clClient.GetListClient(sea);
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            SelectRow = ListCli.CurrentRow.Index;
            clClient.AddClient();
            ListCli.DataSource = clClient.GetListClient(sea);
            ListCli.Rows[SelectRow].Selected = true;
            ListCli.CurrentCell = ListCli[1, SelectRow];
            ListCli.Select();
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            SelectRow = ListCli.CurrentRow.Index;
            clClient.UpdateClient(ListCli.CurrentRow.Cells[0].Value.ToString());
            ListCli.DataSource = clClient.GetListClient(sea);
            ListCli.Rows[SelectRow].Selected = true;
            ListCli.CurrentCell = ListCli[1, SelectRow];
            ListCli.Select();
        }

        private void OpenClient_Click(object sender, EventArgs e)
        {
            SelectRow = ListCli.CurrentRow.Index;
            clClient.OpenClient(ListCli.CurrentRow.Cells[0].Value.ToString());
            ListCli.DataSource = clClient.GetListClient(sea);
            ListCli.Rows[SelectRow].Selected = true;
            ListCli.CurrentCell = ListCli[1, SelectRow];
            ListCli.Select();
        }

        private void PriceTIkBT_Click(object sender, EventArgs e)
        {
            //clOperation.RunPriceTik(empl,ListCli.CurrentRow.Cells[0].Value.ToString());
            clPriceControlOperation.RunPrice(ListCli.CurrentRow.Cells[0].Value.ToString(), empl.id);
        }

        private void DoubTikBT_Click(object sender, EventArgs e)
        {
            clClient cli = new clClient();
            RedCli form = new RedCli(ListCli.CurrentRow.Cells[0].Value.ToString(),true);
            form.onRunDoubPrice += clPriceControlOperation.RunDoub;
            form.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int CountT = 0;
            CountTikEmployees = 0;
            DataTable table = new DataTable();
            table = clControlSer.GetListSerPrice(empl.id, out CountT);
            DG.Rows.Clear();
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                string name = table.Rows[i].ItemArray[1].ToString();
                string nameSer = table.Rows[i].ItemArray[2].ToString();
                string count = table.Rows[i].ItemArray[3].ToString();
                DG.Rows.Add(nameSer,name,count);
                for (int j = 0; j <= DG.Columns.Count - 1; j++)  //Привевт
                {
                    Color col = clSeries.getColorFromChar(table.Rows[i].ItemArray[0].ToString());
                    DG.Rows[DG.Rows.Count - 1].Cells[j].Style.BackColor = col;
                    DG.Rows[DG.Rows.Count - 1].Cells[j].Style.SelectionBackColor = col;
                    DG.Rows[DG.Rows.Count - 1].Cells[j].Style.SelectionForeColor = Color.Black;
                }
                CountTikEmployees = CountT;
            }
            
            CountTik.Text = "Количество доступных билетов: " + CountTikEmployees.ToString() + " шт. ";
            NowTimeDate.Text =  Connect.GetDateServer().ToString();
            SummainKassa.Text = "Сумма в Кассе: " + String.Format("{0:C2}", Kas.SummaInKassa);
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transferTikOperation_Click(object sender, EventArgs e)
        {
            clTransferTickets.RunTransferTik(empl.id);
        }

        private void кассаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenKassaItem_Click(object sender, EventArgs e)
        {
            if (Kas.ControlActiveKassa(1))
            {
                OpenKassaItem.Enabled = false;
                CloseKassaItem.Enabled = true;
                PriceTIkBT.Enabled = true;
                DoubTikBT.Enabled = true;

                // открываем кассу
            }
            
        }

        private void CloseKassaItem_Click(object sender, EventArgs e)
        {
            if (Kas.ControlActiveKassa(0))
            {
                CloseKassaItem.Enabled = false;
                OpenKassaItem.Enabled = true;
                PriceTIkBT.Enabled = false;
                DoubTikBT.Enabled = false;
                //закрываем кассу
            }
            
        }

        private void InsertMoneyToKassa_Click(object sender, EventArgs e)
        {
            Kas.InsertMoneyToKassa();
        }

        private void ReturnMoneyToKassa_Click(object sender, EventArgs e)
        {
            Kas.ReturnMoneyToKassa();
        }

        private void ShowKassaOperItem_Click(object sender, EventArgs e)
        {
            Kas.RunSpKassa();
        }

        private void спискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clListAccess.RunListAccess();
        }
    }
}
