using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ConnectLib;
using UtilDLL;
using libCategory;

namespace LibClient
{
    public class clClient
    {
        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        public string id { get; set; }
        public string lasname { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string note { get; set; }
        public string DateR { get; set; }
        public string type { get; set; }
        public List<clColumns> DopInfo;
        public List<String> ListCategory;

        public clClient()
        {
            this.id = GetGUID();
            this.type = "1";
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataClientToID]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            long count = clColumns.GetCountColumn();
            this.DopInfo = new List<clColumns>();
            for (int i = 1; i <= count; i++)
            {
                this.DopInfo.Add( new clColumns() { Name = ds.Tables[1].Columns[i].ColumnName.ToString() });
                clColumns.GetDataColumn(this.DopInfo[this.DopInfo.Count - 1]);
            }
            this.ListCategory = new List<string>();
        } // Конструктор по умолчанию
        public clClient(string id)
        {
            if (id !="")
            { 
                this.id = id;
                Command = new SqlCommand();
                Command.Connection = connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[GetDataClientToID]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id"].Value = new Guid(id);
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = Command;
                DataSet ds = new DataSet();
                data.Fill(ds);
                this.id = id;
                this.lasname = ds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                this.firstname = ds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();
                this.middlename = ds.Tables[0].Rows[0].ItemArray[3].ToString().Trim();
                this.note = ds.Tables[0].Rows[0].ItemArray[4].ToString().Trim();
                this.DateR = ds.Tables[0].Rows[0].ItemArray[5].ToString().Trim();
                this.type = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                long count = clColumns.GetCountColumn();
                this.DopInfo = new List<clColumns>();
                try
                {
                    for (int i = 1; i <= count; i++)
                    {
                        this.DopInfo.Add(
                            new clColumns()
                            {
                                Name = ds.Tables[1].Columns[i].ColumnName.ToString()
                                ,
                                value = ds.Tables[1].Rows[0].ItemArray[i].ToString().Trim()
                            });
                        clColumns.GetDataColumn(this.DopInfo[this.DopInfo.Count - 1]);
                    }

                    // Загружаем категории
                    this.ListCategory = new List<string>();

                    this.ListCategory = clCateegory.GetListCategoryToIdClient(id);
                }
                catch { }
            }

        } // Возврашает заполнений из базы класс 


        public string GetBigNameClient()
        {
            return this.lasname + " " + this.firstname + " " + this.middlename;
        }

        public string GetSmallNameClient()
        {
            try
            {
                return this.lasname + " " + this.firstname.Substring(0, 1).ToUpper() + "." + this.middlename.Substring(0, 1).ToUpper() + ".";
            }
            catch
            {
                return this.lasname + " " + this.firstname.Substring(0, 1).ToUpper();
            }
        }

        public string GetGUID() // возвращает сгенирированное id 
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GETGUID]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.UniqueIdentifier;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            return Command.Parameters["@ret"].Value.ToString();
        }
        public static void DeleteClient(string id)
        {
            clClient cli = new clClient(id);
            string ret = "";
            Random ran = new Random();
            string intran = ran.Next().ToString();
            DialogResult dialogResult = CLUtils.InputBox(
                "Внимание! Контроль удаления клиента: " + cli.lasname + ' ' + cli.firstname[0].ToString() +'.'+cli.middlename[1].ToString()+'.'
              , "Для подтверждения удаления, необходимо ввести код подтверждения:"
              + intran, ref ret);
            if (dialogResult == DialogResult.OK)
            {
                if (intran == ret) cli.Operation_Delete_Client();
                else MessageBox.Show("Проверочный код, введен не верно!");
            }
        } 
        public static void AddClient()
        {
            clClient cli = new clClient();
            RedCli form = new RedCli();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cli = form.GetData();
                cli.Operation_Add_Client();
            }
        }
        public static void UpdateClient(string id)
        {
            clClient cli = new clClient();
            RedCli form = new RedCli(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                cli = form.GetData();
                cli.Operation_Update_Client();
            }
        }
        public static void OpenClient(string id)
        {
            clClient cli = new clClient();
            RedCli form = new RedCli(id);
            form.ShowDialog();
        }
        public static clClient GetSearchClient(int typeclient =1)
        {
           SearClient sea = new SearClient(typeclient);
           sea.ShowDialog();            
           return sea.GetData();
        } //Возврашает класс по выбору пользователя.
        void Operation_Add_Client()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertClient]";
            Command.Parameters.Add("@idcl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idcl"].Value = new Guid(this.id);
            Command.Parameters.Add("@LastName", SqlDbType.NVarChar, 200);
            Command.Parameters["@LastName"].Value = this.lasname ;
            Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 200);
            Command.Parameters["@FirstName"].Value = this.firstname;
            Command.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 200);
            Command.Parameters["@MiddleName"].Value = this.middlename;
            Command.Parameters.Add("@BD", SqlDbType.NVarChar, 10);
            Command.Parameters["@BD"].Value = this.DateR;
            Command.Parameters.Add("@typecli", SqlDbType.Int);
            Command.Parameters["@typecli"].Value = this.type;
            Command.Parameters.Add("@Note", SqlDbType.NVarChar);
            Command.Parameters["@Note"].Value = this.note;
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            // Очишаем привязку по категория клиент
            clCateegory.CleanCatToClient(this.id);
            // Добавляем новые категории
            for (int i = 0; i <= this.ListCategory.Count - 1; i++)
            clCateegory.InsertConCliCat(this.ListCategory[i].ToString(),this.id,true);
            //  Обновляем дополнительную информацию по клиенту
            for (int i = 0; i <= this.DopInfo.Count - 1; i++)
            SetValueDopInfoToClient(this.DopInfo[i]);
            




        }
        void Operation_Update_Client()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[UpdateClient]";
            Command.Parameters.Add("@idcl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idcl"].Value = new Guid(this.id);
            Command.Parameters.Add("@LastName", SqlDbType.NVarChar, 200);
            Command.Parameters["@LastName"].Value = this.lasname;
            Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 200);
            Command.Parameters["@FirstName"].Value = this.firstname;
            Command.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 200);
            Command.Parameters["@MiddleName"].Value = this.middlename;
            Command.Parameters.Add("@BD", SqlDbType.NVarChar, 10);
            Command.Parameters["@BD"].Value = this.DateR;
            Command.Parameters.Add("@typecli", SqlDbType.Int);
            Command.Parameters["@typecli"].Value = this.type;
            Command.Parameters.Add("@Note", SqlDbType.NVarChar);
            Command.Parameters["@Note"].Value = note;
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            // Очишаем привязку по категория клиент
            clCateegory.CleanCatToClient(this.id);
            // Добавляем новые категории
            for (int i = 0; i <= this.ListCategory.Count - 1; i++)
                clCateegory.InsertConCliCat(this.ListCategory[i].ToString(), this.id, true);
            //  Обновляем дополнительную информацию по клиенту
            for (int i = 0; i <= this.DopInfo.Count - 1; i++)
                SetValueDopInfoToClient(this.DopInfo[i]);
        }
        void Operation_Delete_Client() // Работает на isDelete
        {
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[DeleteClient]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись, успешно удалена!");
        }
        public static DataView GetListClient(string sea,int typeclient =1)
        {
            if (sea == "") sea = "%";
            else sea = sea + "%";
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectClient]";
            Command.Parameters.Add("@sea", SqlDbType.NVarChar, 200);
            Command.Parameters["@sea"].Value = sea;
            Command.Parameters.Add("@typeclient", SqlDbType.Int);
            Command.Parameters["@typeclient"].Value = typeclient;
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds.Tables[0].DefaultView;
        }
        public static void ActiveStyleDataGridViewToClient(DataGridView sender)
        {
            clClient cli = new clClient();
            sender.Columns[0].Visible = false;
            sender.Select();
            for (int i = 1; i <= sender.Columns.Count - 1; i++)
            {
                if (sender.Columns[i].Name == "id")
                {
                    sender.Columns[i].Visible = false;
                    for (int j = 0; j <= cli.DopInfo.Count - 1; j++)
                    {
                        sender.Columns[i + j + 1].HeaderText = cli.DopInfo[j].DisplayName.Trim();
                    }
                    break;
                }

            }

        }
        void SetValueDopInfoToClient(clColumns sender)
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SetDopInfoClientToID]";
            Command.Parameters.Add("@NameField", SqlDbType.NVarChar, 10);
            Command.Parameters["@NameField"].Value = sender.Name;
            Command.Parameters.Add("@Value", SqlDbType.NVarChar, 200);
            Command.Parameters["@Value"].Value = sender.value;
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 10);
            Command.Parameters["@id"].Value = new Guid( this.id);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }
        // --------------------------------------------------------------------------------------------------------------------------------------
    }






}
