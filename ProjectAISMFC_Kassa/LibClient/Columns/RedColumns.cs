using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibClient
{
    public partial class RedColumns : Form
    {
        clColumns col;

        public RedColumns()
        {
            InitializeComponent();
            col = new clColumns();
        }

        public RedColumns(string id)
        {
            InitializeComponent();
            col = new clColumns(id);
            col.id = id;
            NameTB.Text = col.Name;
            DisplayNameTb.Text = col.DisplayName;
            TypeTB.Text = col.Type;
            IndexTB.Text = col.index.ToString();
        }

        public clColumns GetData() { return col; }

        private void OkBT_Click(object sender, EventArgs e)
        {
            col.Name = NameTB.Text;
            col.DisplayName = DisplayNameTb.Text;
            col.Type = TypeTB.Text;
            col.index = 1;
        }

        private void RedColumns_Load(object sender, EventArgs e)
        {

        }
    }
}
