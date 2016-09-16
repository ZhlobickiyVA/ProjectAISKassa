using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace libCategory
{
    public partial class RedCat : Form
    {
        clCateegory cat;
        public RedCat()
        {
            InitializeComponent();
            cat = new clCateegory();
        }

        public RedCat(string id)
        {
            InitializeComponent();
            cat = new clCateegory(id);
            NameCatTB.Text = cat.Name;
            slNameCatTB.Text = cat.slName;
            NoteCatTB.Text = cat.Note;
            PriceCatTB.Text = cat.Price.ToString();
            FlagCB.Checked = cat.flag;
            AcDoubTikCB.Checked = cat.AccesDoubTik;
            NameClientTB.Text = cat.NameClient;
            NameSubClientTB.Text = cat.NameSubClient;
            TypeClientCB.SelectedIndex = cat.TypeClient -1;
        }

        public clCateegory GetData() { return cat; }


        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            cat.Name = NameCatTB.Text;
            cat.slName = slNameCatTB.Text;
            cat.Note = NoteCatTB.Text;
            cat.Price = Convert.ToDouble(PriceCatTB.Text);
            cat.flag = FlagCB.Checked;
            cat.AccesDoubTik = AcDoubTikCB.Checked;
            cat.NameClient = NameClientTB.Text;
            cat.NameSubClient = NameSubClientTB.Text;
            cat.TypeClient = TypeClientCB.SelectedIndex + 1;
        }

        private void FlagCB_CheckedChanged(object sender, EventArgs e)
        {
            NameClientTB.Enabled = FlagCB.Checked;
            NameSubClientTB.Enabled = FlagCB.Checked;
            TypeClientCB.Enabled = FlagCB.Checked;
        }
    }
}
