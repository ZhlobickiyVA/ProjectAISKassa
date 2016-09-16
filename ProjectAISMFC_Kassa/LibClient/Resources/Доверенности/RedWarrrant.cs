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
    

    public partial class RedWarrrant : Form
    {
        clWarrant war;
        clClient cli;

        public RedWarrrant()
        {
            InitializeComponent();
            war = new clWarrant();
            cli = new clClient();


        }

        public RedWarrrant(clClient sender)
        {
            InitializeComponent();
            war = new clWarrant();
            cli = sender;
            LastNameTB.Text = cli.lasname;
            FirstNameTb.Text = cli.firstname;
            MiddleNameTb.Text = cli.middlename;
            war.id_Client = cli.id;
            SelectBT.Enabled = false;
        }


        public RedWarrrant(string id)
        {
            InitializeComponent();
            war = new clWarrant(id);
            cli = new clClient(war.id_Client);
            LastNameTB.Text = cli.lasname;
            FirstNameTb.Text = cli.firstname;
            MiddleNameTb.Text = cli.middlename;
            PassportTb.Text = war.Passport;
            LastNameDovTb.Text = war.LastNameDov;
            FirstNameDovTb.Text = war.FirstNameDov;
            MiddleNameDovTb.Text = war.MiddleNameDov;
            PassportDovTb.Text = war.PassportDov;
            SelectBT.Enabled = false;
        }





        private void RedWarrrant_Load(object sender, EventArgs e)
        {

        }


        public clWarrant GetData() { return war; }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            war.Passport = PassportTb.Text.Trim();
            war.LastNameDov = LastNameDovTb.Text.Trim();
            war.FirstNameDov = FirstNameDovTb.Text.Trim();
            war.MiddleNameDov = MiddleNameDovTb.Text.Trim();
            war.PassportDov = PassportDovTb.Text.Trim();
            war.DataVid = DateB.Value.Date;
            war.DataZav = DateE.Value.Date;
        }

        private void SelectBT_Click(object sender, EventArgs e)
        {
            cli = clClient.GetSearchClient();
            if (cli != null)
            {
                LastNameTB.Text = cli.lasname;
                FirstNameTb.Text = cli.firstname;
                MiddleNameTb.Text = cli.middlename;
                war.id_Client = cli.id;
            }
            
        }

        private void LastNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void GbClient_Enter(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
