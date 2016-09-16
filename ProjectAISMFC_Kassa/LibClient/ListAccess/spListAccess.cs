using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCategory;
using System.Data.SqlClient;
using ConnectLib;

namespace ListAccess
{
    public partial class spListAccess : Form
    {
        clCateegory cat;
        clListAccess Lis;
        public spListAccess()
        {
            InitializeComponent();
            CatCB.DataSource = clCateegory.GetListCategory(true);
            Lis = new clListAccess();
            CatCB.DisplayMember = "Сокрашенное название";
            CatCB.ValueMember = "id";
            CatCB.BeginUpdate();
            CatCB.SelectedIndex = 1;
            CatCB.SelectedIndex = 0;
            CatCB.EndUpdate();
            CatCB.Select();
            cat = new clCateegory(CatCB.SelectedValue.ToString());
            MonthCB.SelectedIndex = DateTime.Now.Month;
            for (int i = 0; i <= YearCB.Items.Count - 1; i++)
            {
                YearCB.SelectedIndex = i;
                if (DateTime.Now.Year.ToString() == YearCB.SelectedItem.ToString()) break;
            }
            Lis.id_Cat = CatCB.SelectedValue.ToString();
            Lis.Month = MonthCB.SelectedIndex;
            Lis.Year = Convert.ToInt32(YearCB.SelectedItem.ToString());
            ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
            ListAcess.Columns[0].Visible = false;

            ListAcess.Columns[1].HeaderText = cat.NameClient;
            ListAcess.Columns[1].Width = 200;
            ListAcess.Columns[2].HeaderText = cat.NameSubClient;
            ListAcess.Columns[2].Width = 200;
            ListAcess.Columns[3].HeaderText = "Дополнительная информация";
            ListAcess.Columns[3].Width = 400;
            //ListAcess.Columns[4].Visible = false;
            //ListAcess.Columns[5].Visible = false;
            //ListAcess.Columns[6].Visible = false;

        }


        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cat = new clCateegory(CatCB.SelectedValue.ToString());
                ListAcess.Columns[1].HeaderText = cat.NameClient;
                ListAcess.Columns[2].HeaderText = cat.NameSubClient;
                Lis.id_Cat = CatCB.SelectedValue.ToString();
                ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
            }
            catch { }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Lis.id_Cat = CatCB.SelectedValue.ToString();
            Lis.Month = MonthCB.SelectedIndex;
            Lis.Year = Convert.ToInt32(YearCB.SelectedItem.ToString());
            ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clListAccess.AddList(Lis);
            ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MonthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MonthCB.SelectedIndex == 0) Lis.Month = 0;
                else Lis.Month = MonthCB.SelectedIndex;
                ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
            } catch { }
        }

        private void YearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (YearCB.SelectedIndex == 0) Lis.Year = 0;
                    else Lis.Year = Convert.ToInt32(YearCB.SelectedItem.ToString());
                
                ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
            }
            catch { }
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clListAccess.UpdateList(this.ListAcess.CurrentRow.Cells[0].Value.ToString());
            ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            clListAccess.DeleteList(this.ListAcess.CurrentRow.Cells[0].Value.ToString());
            ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
        }

        private void CopyBT_Click(object sender, EventArgs e)
        {
            if (this.ListAcess.RowCount != 0)
            {
                if (MessageBox.Show("Все отображенные записи будут перенесены на следующий месяц!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i <= this.ListAcess.RowCount - 1; i++)
                    {
                        clListAccess.TransferList(this.ListAcess.Rows[i].Cells[0].Value.ToString());
                    }
                    ListAcess.DataSource = clListAccess.GetListAccess(Lis,0).DefaultView;
                }
            }
            else MessageBox.Show("Нет данных для переноса!");
        }
    }
}
