using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ConnectLib;


namespace LibEmployees
{
    public class clRole
    {

        public string id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        public clRole() { } // Пустой конструктор

        public clRole(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataRoleToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                this.id = id;
                this.Name = reader["Name"].ToString().Trim();
                this.Level = Convert.ToInt32(reader["Level"]);
            }
            else MessageBox.Show("Пустой запрос! Сотрудник не найден.");
            connection.Close();
            
        }

        public static void RunSpRole()
        {
            spRole role = new spRole(GetListRole());
            role.Show();
        }

        public static void RoleAdd()
        {
            RedRole role = new RedRole();
            if (role.ShowDialog() == DialogResult.OK)
            {
                clRole ro = new clRole();
                ro = role.GetData();
                ro.Operation_ADD_Role();
            }     
        }

        public static void RoleUpdate(string id)
        {
            RedRole role = new RedRole(id);
            clRole ro = new clRole();
            if (role.ShowDialog() == DialogResult.OK)
            {
                
                ro = role.GetData();
                ro.Operation_Update_Role();
            }
        }


        public static DataView GetListRole()
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectRole]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0].DefaultView;
        }
        
        // добавить роль
        void Operation_ADD_Role()
        {
            try
            {
                SqlCommand Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[InsertRole]";
                Command.Parameters.Add("@name", SqlDbType.NVarChar, 100);
                Command.Parameters["@name"].Value = this.Name;
                Command.Parameters.Add("@level", SqlDbType.Int);
                Command.Parameters["@level"].Value = this.Level;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Запись, успешно добавленна!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка транзакции" + error.ToString());

            }
        }
        // обновить роль 
        void Operation_Update_Role()
        {
            try
            {
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[UpdateRole]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id"].Value = new Guid(id);
                Command.Parameters.Add("@name", SqlDbType.NVarChar, 100);
                Command.Parameters["@name"].Value = this.Name;
                Command.Parameters.Add("@level", SqlDbType.Int);
                Command.Parameters["@level"].Value = this.Level;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Запись, успешно добавленна!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка транзакции" + error.ToString());

            }
        }

        public static int GetLevel(string id)
        {
            clRole ro = new clRole(id);
            return ro.Level;
        }

    }

}
