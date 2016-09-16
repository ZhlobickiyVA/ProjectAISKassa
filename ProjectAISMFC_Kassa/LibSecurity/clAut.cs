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

        public int ValudEmpl(string id,string pas,ref int level)
        {
            level = 0;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[Aut]";

            myCommand.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            myCommand.Parameters["@id"].Value = new Guid(id);

            myCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 300);
            myCommand.Parameters["@Password"].Value = pas;


            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Int;
            param.Size = 50;
            param.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(param);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@level";
            param2.SqlDbType = SqlDbType.Int;
            param2.Size = 50;
            param2.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(param2);

            conn.Open();


            myCommand.ExecuteNonQuery();

            conn.Close();


            level = System.Convert.ToInt32(myCommand.Parameters["@level"].Value.ToString().Trim());
            return System.Convert.ToInt32(myCommand.Parameters["@ret"].Value.ToString().Trim());


        }




    }
}
