using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;
using ConnectLib;


namespace libCategory
{
    public class clCateegory
    {

        public string id { get; set; }
        public string Name { get; set; }
        public string slName { get; set; }
        public string Note { get; set; }
        public bool flag { get; set; } // доступность списка разрешения
        public bool AccesDoubTik { get; set; } // доступность двойного билета
        public Double Price { get; set; } // Цена...

        public string NameClient {get;set;}
        public string NameSubClient { get; set; }

        public int TypeClient { get; set; }

        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        public clCateegory() { } // Пустой конструктор
        public clCateegory(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataCategoryToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.Name = reader["Name"].ToString();
                this.slName = reader["slName"].ToString();
                this.Note = reader["Note"].ToString();
                this.flag = Convert.ToBoolean( reader["Flag"].ToString());
                this.Price = Convert.ToDouble(reader["Price"].ToString());
                this.AccesDoubTik = Convert.ToBoolean(reader["AccessDoubPriceTik"].ToString());
                this.NameClient = reader["NameClient"].ToString();
                this.NameSubClient = reader["NameSubClient"].ToString();
                this.TypeClient = Convert.ToInt32(reader["TypeClient"].ToString());
            }
            else MessageBox.Show("Пустой запрос! Сотрудник не найден.");
            connection.Close();
        }
        public static string GetNoteCategory(string id)
        {
            clCateegory cat = new clCateegory(id);
            return cat.Note;
        }
        public static Double GetPriceCategory(string id)
        {
            clCateegory cat = new clCateegory(id);
            return cat.Price;
        }
        public static DataView GetListCategory(bool? flag  = null)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectCategory]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            if (flag != null)
            {
                EnumerableRowCollection<DataRow> query = from table in ds.Tables[0].AsEnumerable()
                                                         where table.Field<bool>("Доступен список разрещения") == Convert.ToBoolean(flag)
                                                         select table;
                return query.AsDataView();
            } else return ds.Tables[0].DefaultView;
        }
        public static void RunSpCategory()
        {
            spCategory cat = new spCategory(GetListCategory());
            cat.Show();

        }
        public static void AddCategory()
        {
            RedCat redcat = new RedCat();
            if (redcat.ShowDialog() == DialogResult.OK)
            {
                clCateegory cat = new clCateegory();
                cat = redcat.GetData();
                cat.Operation_Add_Category();
            }

        }
        public static void UpdateCategory(string id)
        {
            RedCat redcat = new RedCat(id);
            if (redcat.ShowDialog() == DialogResult.OK)
            {
                clCateegory cat = new clCateegory();
                cat = redcat.GetData();
                cat.Operation_Update_Category();
            }

        }
        void Operation_Add_Category()
        {
            try
            {
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[InsertCategory]";
                Command.Parameters.Add("@nameCat", SqlDbType.NVarChar, 50);
                Command.Parameters["@nameCat"].Value = this.Name;
                Command.Parameters.Add("@slNameCat", SqlDbType.NVarChar, 50);
                Command.Parameters["@slNameCat"].Value = this.slName;
                Command.Parameters.Add("@note", SqlDbType.NVarChar);
                Command.Parameters["@note"].Value = this.Note;
                Command.Parameters.Add("@flag", SqlDbType.Bit);
                Command.Parameters["@flag"].Value = this.flag;
                Command.Parameters.Add("@Price", SqlDbType.Money);
                Command.Parameters["@Price"].Value = this.Price;
                Command.Parameters.Add("@AccessDoubPriceTik", SqlDbType.Bit);
                Command.Parameters["@AccessDoubPriceTik"].Value = this.AccesDoubTik;
                Command.Parameters.Add("@NameClient", SqlDbType.NVarChar,300);
                Command.Parameters["@NameClient"].Value = this.NameClient;
                Command.Parameters.Add("@NameSubClient", SqlDbType.NVarChar, 300);
                Command.Parameters["@NameSubClient"].Value = this.NameSubClient;
                Command.Parameters.Add("@TypeClient", SqlDbType.Int);
                Command.Parameters["@TypeClient"].Value = this.TypeClient;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Запись, Добавлена!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка транзакции" + error.ToString());

            }
        }
        void Operation_Update_Category()
        {
            try
            {
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[UpdateCategory]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 50);
                Command.Parameters["@id"].Value = new Guid(this.id);
                Command.Parameters.Add("@nameCat", SqlDbType.NVarChar, 50);
                Command.Parameters["@nameCat"].Value = this.Name;
                Command.Parameters.Add("@slNameCat", SqlDbType.NVarChar, 50);
                Command.Parameters["@slNameCat"].Value = this.slName;
                Command.Parameters.Add("@note", SqlDbType.NVarChar);
                Command.Parameters["@note"].Value = this.Note;
                Command.Parameters.Add("@flag", SqlDbType.Bit);
                Command.Parameters["@flag"].Value = this.flag;
                Command.Parameters.Add("@Price", SqlDbType.Money);
                Command.Parameters["@Price"].Value = this.Price;
                Command.Parameters.Add("@AccessDoubPriceTik", SqlDbType.Bit);
                Command.Parameters["@AccessDoubPriceTik"].Value = this.AccesDoubTik;
                Command.Parameters.Add("@NameClient", SqlDbType.NVarChar, 300);
                Command.Parameters["@NameClient"].Value = this.NameClient;
                Command.Parameters.Add("@NameSubClient", SqlDbType.NVarChar, 300);
                Command.Parameters["@NameSubClient"].Value = this.NameSubClient;
                Command.Parameters.Add("@TypeClient", SqlDbType.Int);
                Command.Parameters["@TypeClient"].Value = this.TypeClient;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Запись, успешно изменена!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка транзакции" + error.ToString());
            }

        }
        public static List<String> GetListCategoryToIdClient(string id)
        {
            List<String> Ret = new List<string>();
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectCatToCli]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.HasRows)
            while (reader.Read()) { Ret.Add(reader["id_Cat"].ToString()); }
            reader.Close();
            return Ret;

        }
        public static void CleanCatToClient(string id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connect.GetConn();
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[ClearCatToClient]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }
        public static void InsertConCliCat(string id_cat, string id_Cli, bool flag)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connect.GetConn();
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[insertConCliCat]";
            Command.Parameters.Add("@id_Cat", SqlDbType.NVarChar, 50);
            Command.Parameters["@id_Cat"].Value = id_cat;
            Command.Parameters.Add("@id_Cli", SqlDbType.NVarChar, 50);
            Command.Parameters["@id_Cli"].Value = id_Cli;
            Command.Parameters.Add("@flag", SqlDbType.Bit);
            Command.Parameters["@flag"].Value = Convert.ToInt32(flag);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }




        //----------------------------------------------------------------------------------------------------------------------
    }
}


        