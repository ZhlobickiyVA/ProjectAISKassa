using CashLib;
using libCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibTickets;

namespace LibARM_Operator
{
    public partial class Doub : Form
    {
        clEventTickets Even;
        clPriceControlOperation Operation;
        public Doub(string idBilet)
        {
            InitializeComponent();
            Even = new clEventTickets(idBilet);
            Operation = new clPriceControlOperation(Even.id_Client,Even.id_Empl);
            Operation.FSender = this.FSender;
            Operation.ControlLabel = this.ControlLabel;
            Operation.Category = new clCateegory(Even.Id_CategoryOper);
            NameTickets.Text = "Производим замену билета: " + Even.Tickets.GetFullName();
            Operation.GetPriceTikToFsender(new LibClient.clClient(Even.id_Client),2,Even.Month.ToString());
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation.DoubTik(Even.id_Bilet.ToString());
        }
    }
}
