using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectLib
{
    static public class Connect
    {
        //public static string ConnectString = "Password=12345;Persist Security Info=True;User ID=sa;Initial Catalog=KassaBilet;Data Source=192.168.88.90";
        //public static string ConnectString = "Password=12345;Persist Security Info=True;User ID=c3user;Initial Catalog=KassaBilet;Data Source=10.49.1.14";

        public static string GetConn()
        {
            //string IpBD = "192.168.88.90";
            //string Password = "12345";
            //string User = "sa";

            //string IpBD = "10.49.1.14";
            //string Password = "12345";
            //string User = "c3user";

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
