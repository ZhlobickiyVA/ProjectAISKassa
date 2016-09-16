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
    public class clDepartment
    {
        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command = new SqlCommand();

        public string id { get; set; }
        public string NameDep { get; set; }

        public clDepartment() { } // Пустой конструктор

        public clDepartment(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataClientToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.NameDep = reader["LastName"].ToString();
            }
            connection.Close();
        }

        public static void RunDepartment()
        {
            spDepartment dep = new spDepartment();
            dep.Show();
        }

        public static void AddDepartment()
        {
            clDepartment dep = new clDepartment();
            string value = "";
            if (CLUtils.InputBox("Создание организиции", "Введите название организации", ref value) == DialogResult.OK)
            {
                dep.NameDep = value;
                dep.Operation_Add_Department();
            }
        }

        public static void UpdateDepartment(string id)
        {
            clDepartment dep = new clDepartment(id);
            string value = dep.NameDep.Trim();
            if (CLUtils.InputBox("Редактирование организиции", "Введите название организации", ref value) == DialogResult.OK)
            {
                dep.NameDep = value;
                dep.Operation_Update_Department();
            }


        }

        public static void DeleteDepartment(string id)
        {
            clDepartment dep = new clDepartment(id);
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выбранную организацию?", "Удаление организации!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dep.Operation_Delete_departmant();
            }


        }


        public static DataTable GetListDepart()
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectDepart]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds.Tables[0];
            //sender.DisplayMember = "Название организации";
            //sender.ValueMember = "id";
        }
        void Operation_Add_Department()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertDep]";
            Command.Parameters.Add("@namedep", SqlDbType.NVarChar, 200);
            Command.Parameters["@namedep"].Value = this.NameDep;
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }
        public void Operation_Update_Department()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[UpdateDep]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            Command.Parameters.Add("@namedep", SqlDbType.NVarChar, 200);
            Command.Parameters["@namedep"].Value = this.NameDep;
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }
        public void Operation_Delete_departmant()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[DeleteDep]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
