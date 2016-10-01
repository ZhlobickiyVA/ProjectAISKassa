using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibTickets;
using UtilDLL;
using LibEmployees;


namespace LibARM_Buhgalter
{

    public partial class ARMBuh2v : Form
    {

        clGetViewTickets GetView = new clGetViewTickets();

        String idEmpl;

        bool checkEmpl { get; set; }
        bool checkser { get; set; }

        public void GetData()
        {
            try
            {
                if (!checkBox2.Checked) GetView.idSer = "0";
                if (!checkBox1.Checked) GetView.idEmpl = "0";
                ListTik.DataSource = GetView.GetListTickeks().DefaultView;
                grid.DataSource = GetView.GetGroupViewGrid().DefaultView;
                if (ListTik.RowCount != 0)
                {
                    ListTik.Columns[0].Visible = false;
                    ListTik.Columns[1].Visible = false;
                    clSeries.RepaintCellgrid(ListTik, 2, 1);
                    grid.Columns[0].Visible = false;
                    grid.Columns[1].Visible = false;
                    grid.Columns[2].HeaderText = "Цвет";
                    grid.Columns[3].HeaderText = "Серия";
                    grid.Columns[4].HeaderText = "С";
                    grid.Columns[5].HeaderText = "По";
                    clSeries.RepaintCellgrid(grid, 2, 1);

                }

            }
            catch (Exception error)
            { MessageBox.Show(error.ToString()); }
        }



        public ARMBuh2v(string id)
        {
            idEmpl = id;
            InitializeComponent();

            EmplCB.DataSource = clEmployees.GetListEmployess(1);
            EmplCB.DisplayMember = "SmallName";
            EmplCB.ValueMember = "id";

            clSeries ser = new clSeries();
            ser.GetListSeries(SerCB);
            BdateTP.Value = Convert.ToDateTime("01.01." + DateTime.Now.Year.ToString());
            EdateTP.Value = Convert.ToDateTime("31.12." + DateTime.Now.Year.ToString());
            GetView.DateB = BdateTP.Value;
            GetView.DateE = EdateTP.Value;

            statusStrip1.Items.Add(clEmployees.GetSmallFIO(id));

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SerCB.Enabled = checkBox2.Checked;
            SerCB.BeginUpdate();
            SerCB.SelectedIndex = 1;
            SerCB.SelectedIndex = 0;
            SerCB.EndUpdate();
        }
        private void StatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetView.status = StatCB.SelectedIndex -1 ;
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            GetData();
            switch (StatCB.SelectedIndex)
            {
                case 2:{ CanceledPanel.Visible = true; break; }
                case 3: { CanceledPanel.Visible = true; break; }
                case 4: { CanceledPanel.Visible = true; break; }
                default: CanceledPanel.Visible = false; break;
            };
            
        }
        private void SerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
                GetView.idSer = SerCB.SelectedValue.ToString();
        }

        private void EmplCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetView.idEmpl = EmplCB.SelectedValue.ToString();
            }
            catch (FormatException Error)
            {
                MessageBox.Show("Выбирете Сотрудника!" + Error.ToString());
            }
        }

        private void ListTik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clSeries.RepaintCellgrid(ListTik,2, 1);
        }

        private void ListTik_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clSeries.RepaintCellgrid(ListTik,2, 1);
        }

        private void ListTik_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clSeries.RepaintCellgrid(ListTik,2, 1);
        }

        private void ARMBuh2v_Shown(object sender, EventArgs e)
        {
            StatCB.SelectedIndex = 0;
            MonthCB.SelectedIndex = 0;
            YearCB.BeginUpdate();
                YearCB.SelectedIndex = 1;
                YearCB.SelectedIndex = 0;
            YearCB.EndUpdate();
            SerCB.SelectedIndex = 1;
            SerCB.SelectedIndex = 0;
            EmplCB.SelectedIndex = 1;
            EmplCB.SelectedIndex = 0;
            ListTik.Visible = true;
            ListTik.Dock = DockStyle.Fill;
            grid.Visible = false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            EmplCB.Enabled = checkBox1.Checked;
            EmplCB.BeginUpdate();
            EmplCB.SelectedIndex = 1;
            EmplCB.SelectedIndex = 0;
            EmplCB.EndUpdate();
        }

        private void AllTikViewCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (AllViewRB.Checked)
            {
                ListTik.Visible = true;
                ListTik.Dock = DockStyle.Fill;
                grid.Visible = false;
            }
            if (GroupViewRB.Checked)
            {
                ListTik.Visible = false;
                grid.Dock = DockStyle.Fill;
                grid.Visible = true;

            }


        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clSeries.RepaintCellgrid(grid,2, 1);
        }

        private void MonthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetView.month = MonthCB.SelectedIndex;
        }

        private void YearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearCB.SelectedIndex == 0) GetView.year = 0;
           else  GetView.year = Convert.ToInt32(YearCB.Text.ToString());
        }

        private void grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clSeries.RepaintCellgrid(grid, 2, 1);
        }

        private void TransferTickets_Click(object sender, EventArgs e)
        {
            clTransferTickets.RunTransferTik(idEmpl);
        }

        private void AddNewPartTik_Click(object sender, EventArgs e)
        {
            clPackTick.RunCreatePackTickets();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void карточкаОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clORG.RunOrganisation();
        }

        private void карточкаОрганизацииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void контрольПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clControlSer.RunControlSer();
        }

        private void журналыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void серииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clSeries.RunSpSeria();
        }
    }
}
