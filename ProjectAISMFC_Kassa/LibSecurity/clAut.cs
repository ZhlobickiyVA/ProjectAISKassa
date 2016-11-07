using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConnectLib;

namespace LibSecurity
{
    public class clAut
    {

        public static bool ValudEmpl(string id,string pas)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connect.GetConn();
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[Aut]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            Command.Parameters.Add("@Password", SqlDbType.NVarChar, 300);
            Command.Parameters["@Password"].Value = pas;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Int;
            param.Size = 50;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToBoolean( System.Convert.ToInt32(Command.Parameters["@ret"].Value.ToString().Trim()));
        }



        public static bool RunAuto(out string ide)
        {
            ide = "";
            FormControlUser co = new FormControlUser();
            if (co.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return co.GetData(out ide);
            }
            return false;
        }




    }
}
