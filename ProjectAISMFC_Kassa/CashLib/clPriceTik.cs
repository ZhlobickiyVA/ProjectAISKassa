using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectLib;
using System.Data;

namespace CashLib
{
    public class clPriceTik
    {







        public static void RunPriceTickets(string IdEmpl, string IdClient)
        { }

        // переводим билет в режим проданных
        public void SaleTik(string idBilet, string idEmpl, string idClient, int month, int year, int status, decimal NomOper, double PriceOper, string idcatoper)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[InsertEventTickeks]";

            myCommand.Parameters.Add("@id_Bilet", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Bilet"].Value = new Guid(idBilet);

            myCommand.Parameters.Add("@id_Empl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Empl"].Value = new Guid(idEmpl);

            myCommand.Parameters.Add("@id_Client", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Client"].Value = new Guid(idClient);

            myCommand.Parameters.Add("@Month", SqlDbType.Int);
            myCommand.Parameters["@Month"].Value = month;

            myCommand.Parameters.Add("@year", SqlDbType.Int);
            myCommand.Parameters["@year"].Value = year;

            myCommand.Parameters.Add("@Status", SqlDbType.Int);
            myCommand.Parameters["@Status"].Value = status;

            myCommand.Parameters.Add("@nomoper", SqlDbType.BigInt);
            myCommand.Parameters["@nomoper"].Value = NomOper;

            myCommand.Parameters.Add("@priceoper", SqlDbType.Money);
            myCommand.Parameters["@priceoper"].Value = PriceOper;

            myCommand.Parameters.Add("@idcatoper", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idcatoper"].Value = new Guid(idcatoper);

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

        }


        public void BrakTik(string idBilet, string idEmpl, int month, int year, int status)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[InsertEventTickeks]";

            myCommand.Parameters.Add("@id_Bilet", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Bilet"].Value = new Guid(idBilet);

            myCommand.Parameters.Add("@id_Empl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Empl"].Value = new Guid(idEmpl);

            myCommand.Parameters.Add("@Month", SqlDbType.Int);
            myCommand.Parameters["@Month"].Value = month;

            myCommand.Parameters.Add("@year", SqlDbType.Int);
            myCommand.Parameters["@year"].Value = year;

            myCommand.Parameters.Add("@Status", SqlDbType.Int);
            myCommand.Parameters["@Status"].Value = status;



            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

        }

        public void DoubTik(string idBilet, string idEmpl, string idClient, int status, string idParTik)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[InsertEventTickeks]";

            myCommand.Parameters.Add("@id_Bilet", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Bilet"].Value = new Guid(idBilet);

            myCommand.Parameters.Add("@id_Empl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Empl"].Value = new Guid(idEmpl);

            myCommand.Parameters.Add("@id_Client", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id_Client"].Value = new Guid(idClient);

            myCommand.Parameters.Add("@idparbil", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idparbil"].Value = new Guid(idParTik);

            myCommand.Parameters.Add("@Status", SqlDbType.Int);
            myCommand.Parameters["@Status"].Value = status;


            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

        }


    }



    ///--------------------------------------------------------------------------------
    /// 



}
