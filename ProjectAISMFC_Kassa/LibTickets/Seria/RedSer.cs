using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibTickets
{
    public partial class RedSer : Form
    {
        clSeries ser = new clSeries();

        public RedSer()
        {
            InitializeComponent();
            ser = new clSeries();
        }

        public RedSer( string id)
        {
            InitializeComponent();
            ser = new clSeries(id);
            NameTb.Text = ser.Name;
            colorpan.BackColor = clSeries.getColorFromChar(ser.Color);
        }

        public clSeries GetData() { return ser; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btCancael_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorpan.BackColor = colorDialog1.Color;
            }
        }

        private void RedSer_Load(object sender, EventArgs e)
        {

        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            ser.Name = NameTb.Text;
            ser.Color = colorpan.BackColor.ToArgb().ToString();
        }
    }
}
