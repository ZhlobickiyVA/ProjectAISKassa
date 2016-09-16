using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ConnectLib;
using UtilDLL;

namespace LibClient
{
    public class clWarrant
    {

        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        public string id { get; set; }
        public string id_Client { get; set; }
        public string Passport { get; set; }
        public string LastNameDov { get; set; }
        public string FirstNameDov { get; set; }
        public string MiddleNameDov { get; set; }
        public string PassportDov { get; set; }
        public DateTime DataVid { get; set; }
        public DateTime DataZav { get; set; }


        public clWarrant() { } // Пустой кконструктор
        public clWarrant(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataWarrantToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.id = reader["id"].ToString();
                this.id_Client = reader["id_client"].ToString();
                this.Passport = reader["Passport"].ToString();
                this.LastNameDov = reader["LastNameDov"].ToString();
                this.FirstNameDov = reader["FirstNameDov"].ToString();
                this.MiddleNameDov = reader["MiddleNameDov"].ToString();
                this.PassportDov = reader["PassportDov"].ToString();
                this.DataVid = Convert.ToDateTime(reader["DateVid"]).Date;
                this.DataZav = Convert.ToDateTime(reader["DateZav"]).Date;
            }
            else MessageBox.Show("Пустой запрос! Доверенность не найдена.");
            connection.Close();

        }

        public static void RunSpWarrant()
        {
            spWarrant war = new spWarrant();
            war.Show();
        }

        public static DataView GetListWarrant(string IdClient = "")
        {

            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectWarrant]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
             
            if (IdClient != "")
            {
                //ds.Tables[0].Columns["Дата окончания"].Expression = "Convert([Дата окончания],'System.DateTime')";
                string str = "('Доверенность на имя ' + [Фамилия (КОМУ)]+' '+ SUBSTRING([Имя (КОМУ)],1,1) +'.'+ SUBSTRING([Отчество (КОМУ)],1,1)+'. действует до '+ [Дата окончания])";
                DataColumn SmallName = new DataColumn("SmallName", typeof(string), str);
                ds.Tables[0].Columns.Add(SmallName);
                EnumerableRowCollection<DataRow> query = from table in ds.Tables[0].AsEnumerable()
                                                         where table.Field<Guid>("id_client") ==  new Guid(IdClient)
                                                         select table;
                return query.AsDataView();
            }
            else return ds.Tables[0].DefaultView;

            
        }

        public static void AddWarrant()
        {
            RedWarrrant war = new RedWarrrant();
            if (war.ShowDialog() == DialogResult.OK)
            {
                clWarrant w = new clWarrant();
                w = war.GetData();
                w.Operation_Add_Warrant();
            }

        }


        public static void AddWarrant(clClient sender)
        {
            RedWarrrant war = new RedWarrrant(sender);
            if (war.ShowDialog() == DialogResult.OK)
            {
                clWarrant w = new clWarrant();
                w = war.GetData();
                w.Operation_Add_Warrant();
            }

        }
        public static void UpdateWarrant(string id)
        {
            RedWarrrant war = new RedWarrrant(id);
            if (war.ShowDialog() == DialogResult.OK)
            {
                clWarrant w = new clWarrant();
                w = war.GetData();
                w.Operation_Update_Warrant();

            }


        }
        public static void DeleteWarrant(string id)
        {
            
            if (MessageBox.Show("Вы уверенны, что хотите удалить доверенность?", "Удаление доверенности!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clWarrant war = new clWarrant(id);
                war.Operation_Delete_Warrant();
            }

        }
        void Operation_Add_Warrant()
        {
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertWarrant]";
            Command.Parameters.Add("@id_client", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id_client"].Value = new Guid(this.id_Client);
            Command.Parameters.Add("@Passport", SqlDbType.NVarChar, 20);
            Command.Parameters["@Passport"].Value = this.Passport.Trim();
            Command.Parameters.Add("@LastNameDov", SqlDbType.NVarChar, 200);
            Command.Parameters["@LastNameDov"].Value = this.LastNameDov.Trim();
            Command.Parameters.Add("@FirstNameDov", SqlDbType.NVarChar, 200);
            Command.Parameters["@FirstNameDov"].Value = this.FirstNameDov.Trim();
            Command.Parameters.Add("@MiddleNameDov", SqlDbType.NVarChar, 200);
            Command.Parameters["@MiddleNameDov"].Value = this.MiddleNameDov.Trim();
            Command.Parameters.Add("@PassportDov", SqlDbType.NVarChar, 20);
            Command.Parameters["@PassportDov"].Value = this.PassportDov.Trim();
            Command.Parameters.Add("@DateVid", SqlDbType.DateTime);
            Command.Parameters["@DateVid"].Value = this.DataVid.Date;
            Command.Parameters.Add("@DateZav", SqlDbType.DateTime);
            Command.Parameters["@DateZav"].Value = this.DataZav.Date;
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись, успешно добавленна!");

        }
        void Operation_Update_Warrant()
        {
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[UpdateWarrant]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            Command.Parameters.Add("@id_client", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id_client"].Value = new Guid(this.id_Client);
            Command.Parameters.Add("@Passport", SqlDbType.NVarChar, 20);
            Command.Parameters["@Passport"].Value = this.Passport.Trim();
            Command.Parameters.Add("@LastNameDov", SqlDbType.NVarChar, 200);
            Command.Parameters["@LastNameDov"].Value = this.LastNameDov.Trim();
            Command.Parameters.Add("@FirstNameDov", SqlDbType.NVarChar, 200);
            Command.Parameters["@FirstNameDov"].Value = this.FirstNameDov.Trim();
            Command.Parameters.Add("@MiddleNameDov", SqlDbType.NVarChar, 200);
            Command.Parameters["@MiddleNameDov"].Value = this.MiddleNameDov.Trim();
            Command.Parameters.Add("@PassportDov", SqlDbType.NVarChar, 20);
            Command.Parameters["@PassportDov"].Value = this.PassportDov.Trim();
            Command.Parameters.Add("@DateVid", SqlDbType.DateTime);
            Command.Parameters["@DateVid"].Value = this.DataVid.Date;
            Command.Parameters.Add("@DateZav", SqlDbType.DateTime);
            Command.Parameters["@DateZav"].Value = this.DataZav.Date;
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись, успешно измененна!");

        }
        void Operation_Delete_Warrant()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[DeleteWarrant]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }



        //----------------------------------------------------------------------------------------------------------------------------------------------------

        public void GetListWarranttoclient(ListBox sender,string id)
        {
            sender.Items.Clear();

            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectWarrantToCli]";

            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "Name";
            sender.ValueMember = "id";

            
            sender.Select();
            connection.Close();

        }

    }
}
