using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ConnectLib;

namespace LibClient
{
    public class clColumns
    {

            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;

            public string id { get; set; }
            public string Name { get; set; }
            public string DisplayName { get; set; }
            public string Type { get; set; }
            public int index { get; set; }
            public string value { get; set; }

            public clColumns() { } //Конструктор по умолчанию

            public clColumns(string id)
            {
                this.id = id;
                Command = new SqlCommand();
                Command.Connection = connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[GetDataColumnsToID]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id"].Value = new Guid(id);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    this.Name = reader["NameColumn"].ToString();
                    this.DisplayName = reader["DisplayName"].ToString();
                    this.Type = reader["Type"].ToString();
                    this.index = Convert.ToInt32(reader["index"].ToString());
                }
                else MessageBox.Show("Пустой запрос!");
                connection.Close();
            }

            public static void GetDataColumn(clColumns sender)
            {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataColumnsToName]";
            Command.Parameters.Add("@Name", SqlDbType.NVarChar,10);
            Command.Parameters["@Name"].Value = sender.Name;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    sender.DisplayName = reader["DisplayName"].ToString();
                    sender.index = Convert.ToInt32(reader["index"].ToString());
                    sender.Type = reader["Type"].ToString();
                }
                else MessageBox.Show("Пустой запрос!");
            connection.Close();
            }


        public static int GetCountColumn()
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataColumnsToName]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToInt32(Command.Parameters["@ret"].Value.ToString())-1;
        }

        public static DataView GetListColumns()
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectColumns]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0].DefaultView;
        }

        public static void RunSpColumns()
        {
            spColumns col = new spColumns();
            col.Show();
        }

        public static void AddColumn()
        {
            RedColumns red = new RedColumns();
            if (red.ShowDialog() == DialogResult.OK)
            {
                clColumns col = new clColumns();
                col = red.GetData();
                col.Operation_Add_Column();
            }

        }

        public static void UpdateColumn(string id)
        {
            RedColumns red = new RedColumns(id);
            if (red.ShowDialog()==DialogResult.OK)
            {
                clColumns col = new clColumns();
                col = red.GetData();
                col.Operation_Update_Column();
            }

        }

        public static void DeleteColumn(string id)
        {
            if (MessageBox.Show("Удалить колонку? Все данные будут утеряны.", "Удаление колонки!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clColumns col = new clColumns(id);
                col.Operation_Delete_Column();
            }

        }

        void Operation_Add_Column()
        {//[InsertColumn]

            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertColumn]";
            Command.Parameters.Add("@DisplayName", SqlDbType.NVarChar, 100);
            Command.Parameters["@DisplayName"].Value = this.DisplayName.Trim();
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }
        void Operation_Update_Column()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[UpdateColumn]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            Command.Parameters.Add("@NameDis", SqlDbType.NVarChar, 100);
            Command.Parameters["@NameDis"].Value = this.DisplayName.Trim();
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }
        void Operation_Delete_Column()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[DeleteColumn]";
            Command.Parameters.Add("@NameField", SqlDbType.NVarChar, 50);
            Command.Parameters["@NameField"].Value = this.Name.Trim();
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }







        // ---------------------------------------------------------------------------------------------------------------------------
    }
}
