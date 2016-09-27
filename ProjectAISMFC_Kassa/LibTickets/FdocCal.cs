using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibEmployees;
using LibTickets;

namespace LibTickets
{
    public partial class Fcal : Form
    {
        public Fcal()
        {
            InitializeComponent();
        }

        private void Fcal_Load(object sender, EventArgs e)
        {

        }

        private void Fcal_Shown(object sender, EventArgs e)
        {
            //clEmployees em = new clEmployees();
            //em.GetListEmployesFromTik(EmplCBFrom, "Оператор");
            //em.GetListEmployesFromTik(CBEMPLret, "Бухгалтер");

        }

        private void SubGroupCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {

        }

        private void InBalancRB_CheckedChanged(object sender, EventArgs e)
        {
            if (InBalancRB.Checked == true)
            {
                InPriceRB.Enabled = false;
                InDublRB.Enabled = false;
                InIsporRB.Enabled = false;
                InOstRB.Enabled = true;
                InOstRB.Checked = true;
                CBEMPLret.Enabled = true;
            }
        }

        private void InArhivRB_CheckedChanged(object sender, EventArgs e)
        {
            if (InArhivRB.Checked == true)
            {
                InPriceRB.Enabled = true;
                InDublRB.Enabled = true;
                InIsporRB.Enabled = true;
                InPriceRB.Checked = true;
                InOstRB.Enabled = false;
                CBEMPLret.Enabled = false;
            }
        }

        private void btOK_Click_1(object sender, EventArgs e)
        {
            

            if (InBalancRB.Checked == true)
            {
                for (int i = 0; i <= ListTik.RowCount - 1; i++)
                {
                    //clTickeks tik = new clTickeks();
                    //tik.InsertEvent(ListTik.Rows[i].Cells[0].Value.ToString(),CBEMPLret.SelectedValue.ToString(),0);


                }
            }

            if (InArhivRB.Checked == true)
            {
                for (int i = 0; i <= ListTik.RowCount - 1; i++)
                {
                    //clTickeks tik = new clTickeks();
                    //tik.InsertEvent(ListTik.Rows[i].Cells[0].Value.ToString(), EmplCBFrom.SelectedValue.ToString(),4);


                }
            }



            MessageBox.Show("Изменения, Успешно внесены!");
            Close();




        }

        private void btResult_Click(object sender, EventArgs e)
        {
            int indate;
            int status = 0;

            if (InOstRB.Checked == true) status = 0;

            if (InPriceRB.Checked == true) status = 1;
            if (InDublRB.Checked == true) status = 2;
            if (InIsporRB.Checked == true) status = 3;
            




            if (rezdate.Checked == true) indate = 1; else indate = 0;


            clTickeks tik = new clTickeks();
            //tik.GetListTickeksForCal(ListTik, 1, EmplCBFrom.SelectedValue.ToString(), status, indate, BdataTP.Value.Date, EdataTP.Value.Date);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
