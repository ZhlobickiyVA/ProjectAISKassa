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
using LibReport;



namespace LibTickets
{
    public partial class TransferFormTik : Form
    {
        clEventTickets even = new clEventTickets();
        clGetViewTickets view = new clGetViewTickets();
        DataTable table;

        public TransferFormTik(string idEmplKto)
        {
            InitializeComponent();
            even.id_Empl = idEmplKto;
            EmplLa.Text = clEmployees.GetSmallFIO(even.id_Empl);
            KomuCB.DataSource = clEmployees.GetListEmployess(1);
            KomuCB.DisplayMember = "SmallName";
            KomuCB.ValueMember = "id";
            KomuCB.BeginUpdate(); KomuCB.SelectedIndex = 1; KomuCB.SelectedIndex = 0; KomuCB.EndUpdate();
            view.idEmpl = even.id_Empl;

            table = new DataTable();
            table = view.GetGroupViewGrid();

            DataGridKto.Columns.Add("id", "id"); DataGridKto.Columns[0].Visible = false;
            DataGridKto.Columns.Add("namecol", "namecol"); DataGridKto.Columns[1].Visible = false;
            DataGridKto.Columns.Add("Color", "Цвет");
            DataGridKto.Columns.Add("Ser", "Серия");
            DataGridKto.Columns.Add("S", "С");
            DataGridKto.Columns.Add("PO", "По");

            for (int i=0;i<=table.Rows.Count-1;i++) DataGridKto.Rows.Add(table.Rows[i].ItemArray);

          

            ResultDG.Columns.Add("namecol","namecol"); ResultDG.Columns[0].Visible = false;
            ResultDG.Columns.Add("Color","Цвет");
            ResultDG.Columns.Add("Ser", "Серия");
            ResultDG.Columns.Add("S", "С");
            ResultDG.Columns.Add("PO", "По");
            
            
        }

        private void SelectMouse()
        {
            try
            {
                BeginValueCB.BeginUpdate(); EndValueCB.BeginUpdate();
                BeginValueCB.Items.Clear(); EndValueCB.Items.Clear();
                SeriesTB.Text = DataGridKto.CurrentRow.Cells[3].Value.ToString();
                int beg = Convert.ToInt32(DataGridKto.CurrentRow.Cells[4].Value.ToString());
                int end = Convert.ToInt32(DataGridKto.CurrentRow.Cells[5].Value.ToString());
                for (int i = beg; i <= end; i++)
                {
                    BeginValueCB.Items.Add(i.ToString("D8"));
                    EndValueCB.Items.Add(i.ToString("D8"));
                }
                BeginValueCB.SelectedIndex = 0;
                EndValueCB.SelectedIndex = EndValueCB.Items.Count - 1;
                BeginValueCB.EndUpdate(); EndValueCB.EndUpdate();
            }
            catch { }


        }


        private void TransferFormTik_Load(object sender, EventArgs e)
        {

        }

        private void KomuCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            even.Id_Empl_Komy = KomuCB.SelectedValue.ToString();
        }

        private void TransferFormTik_Shown(object sender, EventArgs e)
        {
            
            
            even.Id_Empl_Komy = KomuCB.SelectedValue.ToString();

            clSeries.RepaintCellgrid(DataGridKto, 2, 1);
            DataGridKto.Select();
            SelectMouse();
        }

        private void DataGridKto_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void DataGridKto_MouseClick(object sender, MouseEventArgs e)
        {
            SelectMouse();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            string DefBegin = DataGridKto.CurrentRow.Cells[4].Value.ToString();
            string DefEnd = DataGridKto.CurrentRow.Cells[5].Value.ToString();

            string SeriaCol = DataGridKto.CurrentRow.Cells[1].Value.ToString();
            string Begin = BeginValueCB.Text.ToString();
            string End = EndValueCB.Text.ToString();
            // если по левой границу
            if (Convert.ToInt32(DefBegin) == Convert.ToInt32(Begin))
            {
                DataGridKto.CurrentRow.Cells[4].Value = (Convert.ToInt32(End)+1).ToString("D8");
            }
            // если по правой границе
            if (Convert.ToInt32(DefEnd) == Convert.ToInt32(End))
            {
                DataGridKto.CurrentRow.Cells[5].Value = (Convert.ToInt32(Begin) -1).ToString("D8");
            }
            // если в середине диапазона
            if (Convert.ToInt32(DefEnd) != Convert.ToInt32(End) & (Convert.ToInt32(DefBegin) != Convert.ToInt32(Begin)))
            {
                if (DataGridKto.Rows.Count != 0) DataGridKto.Rows.RemoveAt(DataGridKto.CurrentRow.Index);

                DataGridKto.Rows.Add(" ",SeriaCol, " ", SeriesTB.Text, (Convert.ToInt32(DefBegin)).ToString("D8"), (Convert.ToInt32(Begin) - 1).ToString("D8"));

                DataGridKto.Rows.Add(" ",SeriaCol, " ", SeriesTB.Text, (Convert.ToInt32(End) +1).ToString("D8"), (Convert.ToInt32(DefEnd)).ToString("D8"));

                clSeries.RepaintCellgrid(ResultDG, 1, 0);
            }
            // если весь диапазон
            if (Convert.ToInt32(DefEnd) == Convert.ToInt32(End) & (Convert.ToInt32(DefBegin) == Convert.ToInt32(Begin)))
            {
                if (DataGridKto.Rows.Count != 0) DataGridKto.Rows.RemoveAt(DataGridKto.CurrentRow.Index);
            }





            if (SeriesTB.Text != "")
            {
                ResultDG.Rows.Add(SeriaCol, " ", SeriesTB.Text, Begin, End);
                clSeries.RepaintCellgrid(ResultDG, 1, 0);
                
            }

            clSeries.RepaintCellgrid(DataGridKto, 2, 1);
            SelectMouse();
        }

        private void DelBT_Click(object sender, EventArgs e)
        {
            if (ResultDG.Rows.Count != 0)
            {
                ResultDG.Rows.Clear();
                DataGridKto.Rows.Clear();
                for (int i = 0; i <= table.Rows.Count - 1; i++) DataGridKto.Rows.Add(table.Rows[i].ItemArray);
                clSeries.RepaintCellgrid(DataGridKto, 2, 1);
            }
            
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            if (even.id_Empl != even.Id_Empl_Komy)
            {
                
                if (MessageBox.Show("Подтвердите передачу на подотчет!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i <= ResultDG.RowCount - 1; i++)
                    {
                        DataTable table = new DataTable();
                        even.Id_Seria = clSeries.GetDataToName(ResultDG.Rows[i].Cells[2].Value.ToString()).id;
                        string begin = ResultDG.Rows[i].Cells[3].Value.ToString();
                        string end = ResultDG.Rows[i].Cells[4].Value.ToString();
                        table = clGetViewTickets.GetListTickeksBeetwen(even.Id_Seria, 0, begin, end);
                        for (int j = 0; j <= table.Rows.Count - 1; j++)
                        {
                            even.id_Bilet = table.Rows[j].ItemArray[0].ToString();
                            even.InsertEvent();
                        }
                    }
                    MessageBox.Show("Передача прошла успешно!", "Результат!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            } else MessageBox.Show("Передача билетов самим себе, Запрешено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (even.id_Empl.ToUpperInvariant() != even.Id_Empl_Komy.ToUpperInvariant())
            {
                clTransferReportTickets report = new clTransferReportTickets();
                report.Id_Empl_Kto = even.id_Empl;
                report.Id_Empl_Komu = even.Id_Empl_Komy;
                report.Data = ResultDG;
                report.GetReportTransferTickets();
                OkBT.Enabled = true;
            }
            else MessageBox.Show("Передача билетов самим себе, Запрешено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
