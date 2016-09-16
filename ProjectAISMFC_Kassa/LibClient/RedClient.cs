using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConnectLib;
using UtilDLL;
using libCategory;
using LibDataFile;
using System.Diagnostics;

namespace LibClient

{
    public partial class RedCli : Form
    {
        clClient cli;

        public RedCli()
        {
            InitializeComponent();
            cli = new clClient();
        }

        public RedCli(string id)
        {
            InitializeComponent();
            cli = new clClient(id);
            LastNameTB.Text = cli.lasname;
            FirstNameTB.Text = cli.firstname;
            MIddleNameTB.Text = cli.middlename;
            DateRtb.Value = Convert.ToDateTime( cli.DateR).Date;
            NoteTB.Text = cli.note;
        }

        public clClient GetData() { return cli; }

        private void RedCli_Load(object sender, EventArgs e)
        {
            // Заполняем списко категорий
            CheckListCat.DataSource = clCateegory.GetListCategory();
            CheckListCat.DisplayMember = "Название";
            CheckListCat.ValueMember = "id";
            // Отмечаем категории заявителя
            CheckListCat.BeginUpdate();
            for (int i = 0; i <= cli.ListCategory.Count - 1; i++)
                for (int j = 0; j <= CheckListCat.Items.Count - 1; j++)
                {
                    CheckListCat.SelectedIndex = j;
                    if (cli.ListCategory[i] == CheckListCat.SelectedValue.ToString())
                    {
                        CheckListCat.SetItemChecked(j, true);
                    }

                }

            CheckListCat.SelectedIndex = 0;
            CheckListCat.EndUpdate();
            // Загружаем список дополнительной информации
            for (int i = 0; i <= cli.DopInfo.Count - 1; i++)
            {
                InfoView.Items.Add(cli.DopInfo[i].DisplayName.Trim()).SubItems.Add(cli.DopInfo[i].value);
            }
            // Загружаем список доверенностей
            listDov.DataSource = clWarrant.GetListWarrant(cli.id);
            listDov.Columns[0].Visible = false;
            listDov.Columns[1].Visible = false; 
            listDov.Columns[2].Visible = false; 
            listDov.Columns[3].Visible = false; 
            listDov.Columns[4].Visible = false;
            listDov.Columns[5].Visible = false;
            listDov.Columns[6].HeaderText = "Фамилия";
            listDov.Columns[7].HeaderText = "Имя";
            listDov.Columns[8].HeaderText = "Отчество";
            listDov.Columns[9].HeaderText = "Паспорт";
            // загружаем список файлов
            ListFile.DataSource = clDataFile.GetListDataFile(cli.id);
            ListFile.Columns[0].Visible = false;
            ListFile.Columns[1].Width = 200;
            ListFile.Columns[2].Width = 200;

        }

        private void InfoView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ret = InfoView.FocusedItem.SubItems[1].Text;
            if (CLUtils.InputBox("Изменение значения!", "Введите новое значение:"+ InfoView.FocusedItem.Text,  ref ret) == DialogResult.OK)
            {
                InfoView.FocusedItem.SubItems[1].Text = ret;
                cli.DopInfo[InfoView.FocusedItem.Index].value = ret;

            }
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clWarrant.AddWarrant(cli);
            listDov.DataSource = clWarrant.GetListWarrant(cli.id);
        }

        private void EditBTWar_Click(object sender, EventArgs e)
        {
            clWarrant.UpdateWarrant(listDov.CurrentRow.Cells[0].Value.ToString());
            listDov.DataSource = clWarrant.GetListWarrant(cli.id);
        }

        private void DeleteBTWar_Click(object sender, EventArgs e)
        {
            clWarrant.DeleteWarrant(listDov.CurrentRow.Cells[0].Value.ToString());
            listDov.DataSource = clWarrant.GetListWarrant(cli.id);
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            SaveData(); 
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        void SaveData()
        {
            // Основная информация
            cli.lasname = LastNameTB.Text;
            cli.firstname = FirstNameTB.Text;
            cli.middlename = MIddleNameTB.Text;
            cli.DateR = DateRtb.Value.Date.ToString();
            cli.note = NoteTB.Text;
            // Список категорий
            cli.ListCategory.Clear();
            CheckListCat.BeginUpdate();
            for (int i=0; i<=CheckListCat.Items.Count-1;i++)
            {
                CheckListCat.SelectedIndex = i;
                if (CheckListCat.GetItemChecked(i)) cli.ListCategory.Add(CheckListCat.SelectedValue.ToString());
            }
            CheckListCat.SelectedIndex = 0;
            CheckListCat.EndUpdate();
         }

        private void AddFileBT_Click(object sender, EventArgs e)
        {
            clDataFile.AddFile(cli.id);
            ListFile.DataSource = clDataFile.GetListDataFile(cli.id);
        }

        private void DeleteBtFile_Click(object sender, EventArgs e)
        {
            clDataFile.DeleteFile(ListFile.CurrentRow.Cells[0].Value.ToString());
            ListFile.DataSource = clDataFile.GetListDataFile(cli.id);
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            clDataFile.AddFileToScan(cli.id);
            ListFile.DataSource = clDataFile.GetListDataFile(cli.id);
        }

        private void OpenFileBT_Click(object sender, EventArgs e)
        {
            clDataFile dat = new clDataFile(ListFile.CurrentRow.Cells[0].Value.ToString());
            Process.Start(dat.GetFileToArrayByte());
        }
    }
}
