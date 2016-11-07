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
    public class clEmployees
    {

        public string id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateB { get; set; }
        public string Password { set; get; }
        public string idRole { get; set; }
        public string NameRole { get; set; }
        public string DocName { get; set; }
        public string DocSeria { get; set; }
        public string DocNumber { get; set; }
        public string DocOrg { get; set; }
        public DateTime DocDateRet { get; set; }
        public string Dolzhost { get; set; }
        public string Otdel { get; set;}
        public bool Flag {get;set;}

        
        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        
        public clEmployees() {} //КОнструктор по умолчанию

        public clEmployees(string id) // Конструктор с заполнением полей по id из базы
        { //GetDataEmployeesToID
            this.id = id;
            Command = new SqlCommand();            
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataEmployeesToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            
            if (reader.HasRows)
            {
                reader.Read();
                this.LastName = reader["lastName"].ToString();
                this.FirstName = reader["FirstName"].ToString();
                this.MiddleName = reader["MiddleName"].ToString();
                this.DateB = Convert.ToDateTime(reader["BirthDate"].ToString());
                this.idRole = reader["Id_Role"].ToString();
                this.DocName = reader["DocName"].ToString();
                this.DocSeria = reader["DocSeria"].ToString();
                this.DocNumber = reader["DocNumber"].ToString();
                this.DocOrg = reader["DocOrg"].ToString();
                this.DocDateRet = Convert.ToDateTime(reader["DocDateRet"].ToString());
                this.Dolzhost = reader["Dolzh"].ToString();
                this.Otdel = reader["Otdel"].ToString();
                this.Flag = Convert.ToBoolean( reader["Flag"].ToString());
            }
            else MessageBox.Show("Пустой запрос! Сотрудник не найден.");
            connection.Close();

        }

        public string GetSmallFIO() // Фамилия И.О.
        {
            return this.LastName + " " + this.FirstName[0] + "." + this.MiddleName[0]+".";
        }

        public static string GetSmallFIO(string id) // Фамилия И.О.
        {
            clEmployees empl = new clEmployees(id);
            return empl.GetSmallFIO().ToString();
        }

        public static string GetBigFIO(string idEmpl) // Фамиля Имя Отчество
        {
            clEmployees empl = new clEmployees(idEmpl);
            return empl.LastName + " " + empl.FirstName + " " + empl.MiddleName;
        }

        public string GetBigFIO() // Фамиля Имя Отчество
        {
            return this.LastName + " " + this.FirstName + " " + this.MiddleName;
        }

        public static string GetNameRole(string idEmpl)
        {
            clEmployees empl = new clEmployees(idEmpl);
            clRole role = new clRole(empl.idRole);
            return role.Name;
        }

        public string GetPasportString()
        {
            return this.DocName + " " + this.DocSeria + this.DocNumber + " вд. " + this.DocDateRet.ToShortDateString() + "г. " + this.DocOrg;
        }

        public static void RunSpEmployees() // Открытие справочника сотрудников
        {
            FspEmployees empl = new FspEmployees(GetListEmployess());
            empl.Show();
        }

        public static DataView GetListEmployess(int flag = 0 )
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectEmploeess]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();


            if (flag == 1 || flag == 2)
            {
                DataColumn SmallName = new DataColumn("SmallName", typeof(string), "Фамилия +' '+ SUBSTRING(Имя,1,1) +'.'+ SUBSTRING(Отчество,1,1)+'.'");
                ds.Tables[0].Columns.Add(SmallName);
            }

            if (flag == 1)
            {

                EnumerableRowCollection<DataRow> query = from table in ds.Tables[0].AsEnumerable()
                                                         where table.Field<bool>("Flag") == Convert.ToBoolean(flag)
                                                         select table;
                return query.AsDataView();
            }
            else return ds.Tables[0].AsDataView();
        }

        public static void UpdateEmployees(string id)
        {
            FeditSPEmpl RedEmpl = new FeditSPEmpl(id);
            if (RedEmpl.ShowDialog() == DialogResult.OK)
            {
                clEmployees empl = new clEmployees();
                empl = RedEmpl.GetData();
                empl.Operation_Update_Employees();
            }
        }


        public static void AddEmployees()
        {
            FeditSPEmpl RedEmpl = new FeditSPEmpl();
            if (RedEmpl.ShowDialog() == DialogResult.OK)
            {
                clEmployees empl = new clEmployees();
                empl = RedEmpl.GetData();
                empl.Operation_Add_Employees();
            }
        }

        public static void ClearPasswordEmployees(string id)
        {
            string password = "";
            if (CLUtils.InputBox("Сброс пароля!", "Введите новый пароль", ref password) == DialogResult.OK)
            {
                clEmployees empl = new clEmployees();
                empl.Password = password;
                empl.id = id;
                empl.Operation_ClearPassword_Employees();
            }

        }


        void Operation_Add_Employees() 
        {
            try
            {
                Command = new SqlCommand();
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[CreateEmployess]";
                Command.Parameters.Add("@Lastname", SqlDbType.NVarChar, 100);
                Command.Parameters["@Lastname"].Value = this.LastName;
                Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 100);
                Command.Parameters["@FirstName"].Value = this.FirstName;
                Command.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 100);
                Command.Parameters["@MiddleName"].Value = this.MiddleName;
                Command.Parameters.Add("@BirthDate", SqlDbType.Date, 10);
                Command.Parameters["@BirthDate"].Value = this.DateB.Date;
                Command.Parameters.Add("@id_Role", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id_Role"].Value = new Guid(this.idRole);
                Command.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                Command.Parameters["@Password"].Value = this.Password;
                Command.Parameters.Add("@DocName", SqlDbType.NVarChar, 50);
                Command.Parameters["@DocName"].Value = this.DocName;
                Command.Parameters.Add("@DocSeria", SqlDbType.NVarChar, 5);
                Command.Parameters["@DocSeria"].Value = this.DocSeria;
                Command.Parameters.Add("@DocNumber", SqlDbType.NVarChar, 7);
                Command.Parameters["@DocNumber"].Value = this.DocNumber;
                Command.Parameters.Add("@DocOrg", SqlDbType.NVarChar, 200);
                Command.Parameters["@DocOrg"].Value = this.DocOrg;
                Command.Parameters.Add("@DocDateRet", SqlDbType.Date, 10);
                Command.Parameters["@DocDateRet"].Value = this.DateB.Date;
                Command.Parameters.Add("@Flag", SqlDbType.Bit);
                Command.Parameters["@Flag"].Value = Convert.ToInt32(this.Flag);
                Command.Parameters.Add("@Dolzh", SqlDbType.NVarChar, 300);
                Command.Parameters["@Dolzh"].Value = this.Dolzhost;
                Command.Parameters.Add("@Otdel", SqlDbType.NVarChar, 300);
                Command.Parameters["@Otdel"].Value = this.Otdel;
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

        void Operation_Update_Employees()
        {
            try
            {
                Command = new SqlCommand();
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[UpdateEmployess]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id"].Value = new Guid(this.id);
                Command.Parameters.Add("@Lastname", SqlDbType.NVarChar, 100);
                Command.Parameters["@Lastname"].Value = this.LastName;
                Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 100);
                Command.Parameters["@FirstName"].Value = this.FirstName;
                Command.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 100);
                Command.Parameters["@MiddleName"].Value = this.MiddleName;
                Command.Parameters.Add("@BirthDate", SqlDbType.Date, 10);
                Command.Parameters["@BirthDate"].Value = this.DateB.Date;
                Command.Parameters.Add("@id_Role", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id_Role"].Value = new Guid(this.idRole);
                Command.Parameters.Add("@DocName", SqlDbType.NVarChar, 50);
                Command.Parameters["@DocName"].Value = this.DocName;
                Command.Parameters.Add("@DocSeria", SqlDbType.NVarChar, 5);
                Command.Parameters["@DocSeria"].Value = this.DocSeria;
                Command.Parameters.Add("@DocNumber", SqlDbType.NVarChar, 7);
                Command.Parameters["@DocNumber"].Value = this.DocNumber;
                Command.Parameters.Add("@DocOrg", SqlDbType.NVarChar, 200);
                Command.Parameters["@DocOrg"].Value = this.DocOrg;
                Command.Parameters.Add("@DocDateRet", SqlDbType.Date, 10);
                Command.Parameters["@DocDateRet"].Value = this.DateB.Date;
                Command.Parameters.Add("@Dolzh", SqlDbType.NVarChar, 300);
                Command.Parameters["@Dolzh"].Value = this.Dolzhost;
                Command.Parameters.Add("@Otdel", SqlDbType.NVarChar, 300);
                Command.Parameters["@Otdel"].Value = this.Otdel;
                Command.Parameters.Add("@Flag", SqlDbType.Bit);
                Command.Parameters["@Flag"].Value = Convert.ToInt32( this.Flag);
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

        void Operation_ClearPassword_Employees()
        {
            try
            {
                Command = new SqlCommand();
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[ClearPaswwdEmp]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id"].Value = new Guid(this.id);
                Command.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                Command.Parameters["@Password"].Value = this.Password;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Пароль изменен!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка транзакции" + error.ToString());

            }

        }

        //------------------------------------------------------------------------------------------------------------------------------------------------


        public void GetListEmployess(ComboBox sender, string role)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectEmploeessWhereRole]";

            Command.Parameters.Add("@Role", SqlDbType.NVarChar, 50);
            Command.Parameters["@Role"].Value = role;

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;
            
            
            sender.DisplayMember = "FIO";
            sender.ValueMember = "id";
            connection.Close();

        }

        public void GetListEmployesFromTik_(ComboBox sender, string role)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetEmplTik]";

            Command.Parameters.Add("@role", SqlDbType.NVarChar, 50);
            Command.Parameters["@role"].Value = role;

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "Empl";
            sender.ValueMember = "idempl";
            connection.Close();

        }
        // получение списка сотрудников для комбобокса
        public void GetListEmployess(ComboBox sender)
        {
            string qert = "SELECT [id],[lastName] +' '+ left(FirstName,1) +'.'+ left([MiddleName],1)+'.'  as 'FIO' FROM [spEmployees]";
            SqlConnection connection = new SqlConnection(Connect.GetConn());

            SqlDataAdapter data = new SqlDataAdapter(qert, connection);

            DataSet ds = new DataSet();

            data.Fill(ds);
            sender.DataSource= ds.Tables[0].DefaultView;
            sender.DisplayMember = "FIO";
            sender.ValueMember = "id";

            sender.SelectedIndex = 0;
                       
            connection.Close();
        
       }



    }
}
