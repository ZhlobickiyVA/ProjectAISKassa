using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ConnectLib;
using UtilDLL;

namespace LibEmployees
{
    public class clORG
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string slName { get; set; }
        public string Phone { get; set; }
        public string Director { get; set; }
        public string DocOsnCom { get; set; }
        public string PredComDolzh { get; set; }
        public string PredComFio { get; set; }
        public string cl1ComDolzh { get; set; }
        public string cl1ComFIo { get; set; }
        public string cl2ComDolzh { get; set; }
        public string cl2ComFIo { get; set; }
        public string cl3ComDolzh { get; set; }
        public string cl3ComFIo { get; set; }

        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;


        public clORG()
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataOrg]";
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.id = reader["id"].ToString();
                this.Name = reader["NameORG"].ToString();
                this.slName = reader["slNameOrg"].ToString();
                this.Phone = reader["Phone"].ToString();
                this.DocOsnCom = reader["DocOsnKomissia"].ToString();
                this.PredComDolzh = reader["PredComDolzh"].ToString();
                this.PredComFio = reader["PredComFio"].ToString();
                this.cl1ComDolzh = reader["cl1ComDolzh"].ToString();
                this.cl1ComFIo = reader["cl1ComFio"].ToString();
                this.cl2ComDolzh = reader["cl2ComDolzh"].ToString();
                this.cl2ComFIo = reader["cl2ComFio"].ToString();
                this.cl3ComDolzh = reader["cl3ComDolzh"].ToString();
                this.cl3ComFIo = reader["cl3ComFio"].ToString();
                this.Director = reader["Director"].ToString();
            }
            connection.Close();

        }
        public string GetCommisia()
        {
            return this.PredComDolzh + " " + this.PredComFio + ", "
                + this.cl1ComDolzh + " " + this.cl1ComFIo + ", "
                + this.cl2ComDolzh + " " + this.cl2ComFIo + ", "
                + this.cl3ComDolzh + " " + this.cl3ComFIo;
        }

        public string GetNPACommisia(DateTime Begin, DateTime End)
        {
            return this.DocOsnCom + ", составила настоящий акт в том, что за период с " + Begin.ToShortDateString() +
                " по " + End.ToShortDateString() + "подлежат списанию.";

        }

        void Operation_Update_Org()
        {
            try
            {
                Command = new SqlCommand();
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[UpdateORG]";
                Command.Parameters.Add("@NameORG", SqlDbType.NVarChar, 500);
                Command.Parameters["@NameORG"].Value = this.Name.ToString();
                Command.Parameters.Add("@slNameORG", SqlDbType.NVarChar, 100);
                Command.Parameters["@slNameORG"].Value = this.slName.ToString();
                Command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20);
                Command.Parameters["@Phone"].Value = this.Phone.ToString();
                Command.Parameters.Add("@DocOsnKomissia", SqlDbType.NVarChar, 500);
                Command.Parameters["@DocOsnKomissia"].Value = this.DocOsnCom.ToString();
                Command.Parameters.Add("@PredComDolzh", SqlDbType.NVarChar, 100);
                Command.Parameters["@PredComDolzh"].Value = this.PredComDolzh.ToString();
                Command.Parameters.Add("@PredComFio", SqlDbType.NVarChar, 100);
                Command.Parameters["@PredComFio"].Value = this.PredComFio.ToString();
                Command.Parameters.Add("@cl1ComDolzh", SqlDbType.NVarChar, 100);
                Command.Parameters["@cl1ComDolzh"].Value = this.cl1ComDolzh.ToString();
                Command.Parameters.Add("@cl1ComFio", SqlDbType.NVarChar, 100);
                Command.Parameters["@cl1ComFio"].Value = this.cl1ComFIo.ToString();
                Command.Parameters.Add("@cl2ComDolzh", SqlDbType.NVarChar, 100);
                Command.Parameters["@cl2ComDolzh"].Value = this.cl2ComDolzh.ToString();
                Command.Parameters.Add("@cl2ComFio", SqlDbType.NVarChar, 100);
                Command.Parameters["@cl2ComFio"].Value = this.cl2ComFIo.ToString();
                Command.Parameters.Add("@cl3ComDolzh", SqlDbType.NVarChar, 100);
                Command.Parameters["@cl3ComDolzh"].Value = this.cl3ComDolzh.ToString();
                Command.Parameters.Add("@cl3ComFio", SqlDbType.NVarChar, 100);
                Command.Parameters["@cl3ComFio"].Value = this.cl3ComFIo.ToString();
                Command.Parameters.Add("@Director", SqlDbType.NVarChar, 100);
                Command.Parameters["@Director"].Value = this.cl3ComFIo.ToString();
                connection.Open();
                    Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Запись, успешно обновлена!");
            }
            catch (Exception error)
            {MessageBox.Show("Ошибка транзакции" + error.ToString());}
        }

        public static void RunOrganisation()
        {
            spRedOrg red = new spRedOrg();
            clORG org = new clORG();
            if (red.ShowDialog() == DialogResult.OK)
            {
                org = red.Getdata();
                org.Operation_Update_Org();
            }
        }


        public static string GetGlBuh()
        {
            clORG org = new clORG();
            string rez = "Главный бухгалтер";

            if (org.PredComDolzh == rez) return org.PredComFio.ToString();
            if (org.cl1ComDolzh == rez) return org.cl1ComFIo.ToString();
            if (org.cl2ComDolzh == rez) return org.cl2ComFIo.ToString();
            if (org.cl3ComDolzh == rez) return org.cl3ComFIo.ToString();
            else return "";
        }
    }
}
