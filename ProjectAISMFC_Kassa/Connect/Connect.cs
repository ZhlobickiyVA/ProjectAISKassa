﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectLib
{
    static public class Connect
    {
        public static string GetConn()
        {

            string IpBD = "10.49.1.31";
            string Password = "Frdfhbev89@";
            string User = "sa";

            return "Password =" + Password + " ; Persist Security Info = True; User ID =" + User
                + " ; Initial Catalog = KassaBilet; Data Source =" + IpBD;

                        
            //return ConnectString;
        }

        

        static public DateTime GetDateServer() // возвращает дату и время от сервера
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connect.GetConn();
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GETDatetime]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.DateTime;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToDateTime(Command.Parameters["@ret"].Value.ToString());
        }


    }
}
