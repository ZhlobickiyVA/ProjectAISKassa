using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace libCategory
{
    public partial class spCategory : Form
    {
        public spCategory(DataView sender)
        {
            InitializeComponent();

            ListCat.DataSource = sender;
            ListCat.Columns[0].Visible = false;
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            clCateegory.AddCategory();
            this.ListCat.DataSource = clCateegory.GetListCategory();
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            clCateegory.UpdateCategory(ListCat.CurrentRow.Cells[0].Value.ToString());
            this.ListCat.DataSource = clCateegory.GetListCategory();
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
