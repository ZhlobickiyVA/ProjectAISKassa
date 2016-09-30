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
using libCategory;
using LibTickets;
using LibClient;
using LibARM_Buhgalter;
using ListAccess;
using LibDataFile;
using UtilDLL;
using LibARM_Operator;

namespace GeneralMidule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clEmployees.RunSpEmployees();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clCateegory.RunSpCategory();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            clSeries.RunSpSeria();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            clClient.UpdateClient("D2CCCA5C-4C75-4753-B509-0ACD83071785");  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clWarrant.RunSpWarrant();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clClient.GetSearchClient().lasname);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clColumns.RunSpColumns();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clPackTick.RunCreatePackTickets();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clARM_Buhgalter.Run_ARM("0FE342D2-B667-4706-BCD8-51BA63864A19");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clTransferTickets.RunTransferTik("2BA2A578-A7B0-47C4-98EC-0DFFCD52734F");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clDataFile data = new clDataFile();
            clDataFile.GetImageFromScan();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clDepartment.RunDepartment();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clListAccess.RunListAccess();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clControlSer.RunControlSer();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clDataFile.RunListFileReport();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ARMOperatorV2 oper = new ARMOperatorV2("2BA2A578-A7B0-47C4-98EC-0DFFCD52734F");
            oper.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clORG.GetGlBuh());

        }
    }
}
