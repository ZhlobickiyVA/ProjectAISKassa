using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectLib;
using UtilDLL;
using System.Data;
using System.Windows.Forms;
using libCategory;

namespace ListAccess
{
    public class clListAccess
    {
        public clCateegory cat;
        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command = new SqlCommand();


        public string id { get; set; }
        public string id_Client { get; set; }
        public string id_SubClient { get; set; }
        public string Note { get; set; }
        public string id_Cat { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public clListAccess()
        {

        } // Путой конструктор
        public clListAccess(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataListAccessToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.id_Client = reader["id_Client"].ToString();
                this.id_SubClient = reader["id_SubClient"].ToString();
                this.Note = reader["Note"].ToString();
                this.id_Cat = reader["id_Cat"].ToString();
                this.Month = Convert.ToInt32( reader["Month"].ToString());
                this.Year = Convert.ToInt32( reader["Year"].ToString());
            }
            else MessageBox.Show("Пустой запрос!");
            connection.Close();
        }

        
        public static void RunListAccess()
        {
            spListAccess Lis = new spListAccess();
            Lis.Show();
        }

        public static DataTable GetListAccess(clListAccess lis,int indexTable)
        {
            // 0 - справочник
            // 1 - отображает поиск по клиенту
            // 2 - отображает поиск по субклиенту
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectListAccess]";
            Command.Parameters.Add("@Id_Cat", SqlDbType.NVarChar, 40);
            Command.Parameters["@Id_Cat"].Value = lis.id_Cat;
            Command.Parameters.Add("@Month", SqlDbType.Int);
            Command.Parameters["@Month"].Value = lis.Month;
            Command.Parameters.Add("@Year", SqlDbType.Int);
            Command.Parameters["@Year"].Value = lis.Year;
            if (lis.id_Client != "" && lis.id_Client != null)
            {
                Command.Parameters.Add("@idClient", SqlDbType.UniqueIdentifier);
                Command.Parameters["@idClient"].Value = new Guid(lis.id_Client);
            }
            if (lis.id_SubClient != "" && lis.id_SubClient != null)
            {
                Command.Parameters.Add("@idSubClient", SqlDbType.UniqueIdentifier);
                Command.Parameters["@idSubClient"].Value = new Guid(lis.id_SubClient);
            }
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[indexTable];
        }

        public static void AddList(clListAccess lis)
        {
            clListAccess list = new clListAccess();
            RedListAccess red = new RedListAccess(lis);
            if (red.ShowDialog() == DialogResult.OK)
            {
                list = red.GetData();
                list.Operation_Add_ListAccess();
                list.id_Client = "";
                list.id_SubClient = "";
            }

        }

        public static void UpdateList(string id)
        {
            clListAccess list = new clListAccess(id);
            RedListAccess red = new RedListAccess(list);
            if (red.ShowDialog() == DialogResult.OK)
            {
                list = red.GetData();
                list.Operation_Update_ListAccess();
                list.id_Client = "";
                list.id_SubClient = "";
            }
        }

        public static void DeleteList(string id)
        {
            clListAccess list = new clListAccess(id);
            if (MessageBox.Show("Вы действительно хотите удалить выбранную запись?","Удаление записи!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                list.Operation_Delete_ListAccess();
            }
        }

        public static void TransferList(string id)
        {
            clListAccess lis = new clListAccess(id);
            if (lis.Month == 12)
            {
                lis.Month = 1;
                lis.Year++;
            }
            else lis.Month++; 
            lis.Operation_Add_ListAccess();
        }



        void Operation_Add_ListAccess()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertAccessList]";
            Command.Parameters.Add("@idClient", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idClient"].Value = new Guid(this.id_Client);
            Command.Parameters.Add("@idSubClient", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idSubClient"].Value = new Guid(this.id_SubClient);
            Command.Parameters.Add("@idCat", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idCat"].Value = new Guid(this.id_Cat);
            Command.Parameters.Add("@Note", SqlDbType.NVarChar,500);
            Command.Parameters["@Note"].Value = this.Note;
            Command.Parameters.Add("@Month", SqlDbType.Int);
            Command.Parameters["@Month"].Value = this.Month;
            Command.Parameters.Add("@Year", SqlDbType.Int);
            Command.Parameters["@Year"].Value = this.Year;
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }

        void Operation_Update_ListAccess()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[UpdateAccessList]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            Command.Parameters.Add("@idClient", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idClient"].Value = new Guid(this.id_Client);
            Command.Parameters.Add("@idSubClient", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idSubClient"].Value = new Guid(this.id_SubClient);
            Command.Parameters.Add("@idCat", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idCat"].Value = new Guid(this.id_Cat);
            Command.Parameters.Add("@Note", SqlDbType.NVarChar, 500);
            Command.Parameters["@Note"].Value = this.Note;
            Command.Parameters.Add("@Month", SqlDbType.Int);
            Command.Parameters["@Month"].Value = this.Month;
            Command.Parameters.Add("@Year", SqlDbType.Int);
            Command.Parameters["@Year"].Value = this.Year;
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            
        }

        void Operation_Delete_ListAccess()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[DeleteAccessList]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
