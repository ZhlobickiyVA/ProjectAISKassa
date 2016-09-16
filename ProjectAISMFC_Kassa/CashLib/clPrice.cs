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


namespace LibARM_Operator
{
    class clPrice
    {


        public clPrice() { }


        



        public void saletik(string idclient,string idempl)
        {
            //Price pri = new Price(idempl,idclient);
            //clCateegory cat = new clCateegory();
            //clWarrant war = new clWarrant();

            //war.GetListWarranttoclient(pri.ListDov,idclient);
            //cat.GetListCategory(pri.ListCat, idclient);
            //pri.ListCat.Select();

            
            //pri.stringlist = ControlString;

            //if (pri.ListDov.Items.Count == 0) pri.AddWar2.Visible = true;
            //if (pri.ListCat.Items.Count == 0) MessageBox.Show("Действие не возможно, нет доступных категорий!");
            
            //else pri.ShowDialog();


        }



        public int GetValidOprhan(string idcli,DateTime dat) 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[GETValidOrphan]";

            myCommand.Parameters.Add("@cli", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@cli"].Value = new Guid(idcli);

            myCommand.Parameters.Add("@mon", SqlDbType.DateTime);
            myCommand.Parameters["@mon"].Value = dat.Date;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(param);

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

            return Convert.ToInt32(myCommand.Parameters["@ret"].Value.ToString());

        }

        public int GetValidPrice(string idcli,int mon, int year,string idcat)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[GETValidPrice]";

            myCommand.Parameters.Add("@cli", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@cli"].Value = new Guid(idcli);

            myCommand.Parameters.Add("@mon", SqlDbType.Int);
            myCommand.Parameters["@mon"].Value = mon;

            myCommand.Parameters.Add("@yea", SqlDbType.Int);
            myCommand.Parameters["@yea"].Value = year;

            myCommand.Parameters.Add("@idcat", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idcat"].Value = new Guid(@idcat);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(param);

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

            return Convert.ToInt32(myCommand.Parameters["@ret"].Value.ToString());

        }

        public int GetValidOpek(string idcli, DateTime dat)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[GETValidOpek]";

            myCommand.Parameters.Add("@cli", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@cli"].Value = new Guid(idcli);

            myCommand.Parameters.Add("@mon", SqlDbType.DateTime);
            myCommand.Parameters["@mon"].Value = dat.Date;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(param);

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

            return Convert.ToInt32(myCommand.Parameters["@ret"].Value.ToString());

        }



    }
}
