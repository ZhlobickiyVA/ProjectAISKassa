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

namespace UtilDLL
{
    public class clFix
    {
        public static long GetFix() // возвращает номер кассовой операции
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GETFIX]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.BigInt;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToInt64(Command.Parameters["@ret"].Value);
        }   
        public static Decimal GetTransferFIX() // возвращает номер операции передачи операции
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GETFIXTRANSFER]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.BigInt;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToDecimal(Command.Parameters["@ret"].Value);
        }
        public static Decimal GetCanceledFIX() // возвращает номер операции списания операции
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GETFIXCANCELLED]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.BigInt;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToDecimal(Command.Parameters["@ret"].Value);

        }

        public static Decimal GetCloseKasFIX() // возвращает номер операции списания операции
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GETFIXCLOSEKASSA]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.BigInt;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToDecimal(Command.Parameters["@ret"].Value);

        }

    }
}
