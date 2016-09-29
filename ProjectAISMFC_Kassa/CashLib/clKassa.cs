using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConnectLib;
using UtilDLL;
using System.Globalization;
using LibEmployees;
using LibReport;

namespace CashLib
{
    public class clKassa
    {





        public string id { get; set; }
        public long? NomOper { get; set; }
        public DateTime DateOperation { get; set; }
        public Double Debet { get; set; }
        public Double Kredit { get; set; }
        public string idEmpl { get; set; }
        public string NameKassa { get; }
        public int ActiveKassa { get; set; }
        public Double SummaInKassa
        {
            get { return GetMoneyToKassa();}
        }
        public Double SolDoBegin { get;set;}
        public Double SoldoEnd { get; set; }

        

        public DateTime SoldoBeginDate { get; set; }

        public DateTime SoldoEndDate { get; set; }



        public clReportCloseKassa.ParCloseKassa Par;



        public bool ControlActiveKassa(int i /* 1 - open;0-Close */)
        {
            bool ret = false;
            this.ActiveKassa = i;
            if (i == 1) // open
            {
                this.SolDoBegin = this.SummaInKassa;
                this.SoldoBeginDate = Connect.GetDateServer();
                this.Operation_UpdateActive_spKassa();
                MessageInfo info = new MessageInfo();
                info.Lin.Add("Касса открыта!");
                info.Lin.Add("Сальдо на начало дня: "+ String.Format("{0:C2}", this.SolDoBegin));
                info.ShowDialog();
                ret = true;
            }
            if (i == 0) // close
            {
                this.SoldoEnd = this.SummaInKassa;
                this.SoldoEndDate = Connect.GetDateServer();
                // запускаем форму настройки закрытия кассы.
                fCloseKas fclose = new fCloseKas(this);
                if (fclose.ShowDialog() == DialogResult.OK)
                {
                    
                    this.Operation_UpdateActive_spKassa();
                    ret = true;
                    // TODO: Надо вычесть из кассы деньги
                    this.NomOper = clFix.GetFix();
                    this.addEventMoneytoKass();
                    MessageInfo info = new MessageInfo();
                    info.Lin.Add("Касса закрыта!");
                    info.Lin.Add("Сальдо на конец дня: " + String.Format("{0:C2}", this.SoldoEnd));
                    info.ShowDialog();
                }

            }
            return ret;
        }
        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;
        public clKassa() {} // Пустой конструктор
        public clKassa(string idEmpl)
        {
            this.idEmpl = idEmpl;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataSpKassa]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.idEmpl);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.NameKassa = reader["Name"].ToString();
                this.ActiveKassa = Convert.ToInt32( reader["Active"].ToString());
                this.SoldoBeginDate = Convert.ToDateTime(reader["DateOpen"].ToString());
                this.SoldoEndDate = Convert.ToDateTime(reader["DateClose"].ToString());
                this.SolDoBegin = Convert.ToDouble(reader["SoldoBegin"].ToString());
            }
            connection.Close();
            this.Par.FioGlBuh = clORG.GetGlBuh();
            this.Par.IdEmpl = this.idEmpl;
        }
        void Operation_UpdateActive_spKassa()
        {
            try
            {
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[UpdateActiveSpKassa]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id"].Value = new Guid(this.idEmpl);
                Command.Parameters.Add("@act", SqlDbType.Int);
                Command.Parameters["@act"].Value = this.ActiveKassa;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка транзакции" + error.ToString());

            }
        }
        // Отображаем список операций
        public DataTable GetListKassa()
        {
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[_SelectMoneyKassa]";
            Command.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idempl"].Value = new Guid(this.idEmpl);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }
        // добавляем запись в кассовую книгу
        public void addEventMoneytoKass()
        {

            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[_InsertEventMoneyKassa]";
            Command.Parameters.Add("@nom", SqlDbType.BigInt);
            Command.Parameters["@nom"].Value = this.NomOper;
            Command.Parameters.Add("@kredit", SqlDbType.Money);
            Command.Parameters["@kredit"].Value = Convert.ToDouble(this.Kredit);
            Command.Parameters.Add("@debet", SqlDbType.Money);
            Command.Parameters["@debet"].Value = Convert.ToDouble(this.Debet);
            Command.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idempl"].Value = new Guid(this.idEmpl);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }
        // получаем сумму в кассе у заданного сотрудника
        public Double GetMoneyToKassa()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[_GetSumMoneyKassa]";
            Command.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idempl"].Value = new Guid(this.idEmpl);
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.Real;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            if (Command.Parameters["@ret"].Value.ToString() != "")
                return Convert.ToDouble( Command.Parameters["@ret"].Value.ToString());
            else return 0.00;
        }
        // Добавляем деньги в кассу
        public void InsertMoneyToKassa()
        {
            string sep = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
            string ret = "";
            if (CLUtils.InputBox("Ввод значения!", "Введите сумму которую хотите добавить в кассу!", ref ret) == DialogResult.OK)
            {
                double dob = 0;
                if (Double.TryParse(ret, out dob))
                {
                    this.Debet = dob;
                    this.Kredit = 0;
                    this.addEventMoneytoKass();
                    //TODO: Как это фиксируется +
                }
                else MessageBox.Show("Неверный формат значения! Повторите попытку еще раз. Разделитель дробной части: [ " + sep + " ]");
            }
        }
        // Инкасируем деньги из кассы
        public void ReturnMoneyToKassa()
        {
            string ret = "";
            string sep = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
            if (CLUtils.InputBox("Ввод значения!", "Введите сумму которую хотите изьять из кассы!", ref ret) == DialogResult.OK)
            {
                double dob = 0;
                if (Double.TryParse(ret, out dob))
                {
                    if (dob <= SummaInKassa)
                    {
                        this.Debet = 0;
                        this.Kredit = dob;
                        this.addEventMoneytoKass();
                        //TODO: Как это фиксируется -
                    }
                    else MessageBox.Show("В кассе нет такой суммы!");
                }
                else MessageBox.Show("Неверный формат значения! Повторите попытку еще раз. Разделитель дробной части: [ " + sep+" ]");
            }

        }

        public void RunSpKassa()
        {
            spKassa Kassa = new spKassa(this);
            Kassa.Show();
        }

        public DataTable GetItogToPrice()
        {
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetItogPrice]";
            Command.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idempl"].Value = new Guid(this.idEmpl);
            Command.Parameters.Add("@DateBegin", SqlDbType.DateTime);
            Command.Parameters["@DateBegin"].Value = SoldoBeginDate;
            Command.Parameters.Add("@DateEnd", SqlDbType.DateTime);
            Command.Parameters["@DateEnd"].Value = SoldoEndDate;
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();

            

            return ds.Tables[0];




        }



    }
}