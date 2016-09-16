using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;
using ConnectLib;

namespace LibEventLog
{
    public class clLog
    {
        public void InsertLog(string idEmpl, int code)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[InsertLog]";

            myCommand.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idempl"].Value = new Guid(idEmpl);

            myCommand.Parameters.Add("@code", SqlDbType.Int);
            myCommand.Parameters["@code"].Value = code;

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

        }

        public void InsertLog(string idEmpl, int code, decimal price)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[InsertLog]";

            myCommand.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idempl"].Value = new Guid(idEmpl);

            myCommand.Parameters.Add("@code", SqlDbType.Int);
            myCommand.Parameters["@code"].Value = code;

            myCommand.Parameters.Add("@price", SqlDbType.Money);
            myCommand.Parameters["@price"].Value = price;

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

        }


        public int GetValidOpenKas(string idEmpl) 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[_GetValidOpenKassa]";

            myCommand.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idempl"].Value = new Guid(idEmpl);

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


        public int GetValidCloseKas(string idEmpl) 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[_GetValidCloseKassa]";

            myCommand.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idempl"].Value = new Guid(idEmpl);

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

        public Double GetSoldoBeginDay(string idEmpl)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[_GetSaldoBeginDay]";

            myCommand.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@idempl"].Value = new Guid(idEmpl);

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Money;
            param.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(param);

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

            return Convert.ToDouble(myCommand.Parameters["@ret"].Value.ToString());

        }
    }
}
