using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using ConnectLib;


namespace LibTickets
{
   
    public class clPackTick // Класс Создание нового пакета билетов
    {
        public static void CreatePackTik(string id_empl, string idSeria, int BeginValue, int Count) // Создать пакет билетов
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertPackegeTickeks]";
            Command.Parameters.Add("@id_series", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id_series"].Value = new Guid(idSeria);
            Command.Parameters.Add("@id_Empl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id_Empl"].Value = new Guid(id_empl);
            Command.Parameters.Add("@InitialValue", SqlDbType.Int);
            Command.Parameters["@InitialValue"].Value = BeginValue;
            Command.Parameters.Add("@count", SqlDbType.Int);
            Command.Parameters["@count"].Value = Count;
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Успешно");
        }

        public static void RunCreatePackTickets()
        {
            RedAddTik red = new RedAddTik();
            red.ShowDialog();
        }
    }
    public class clTransferTickets
    {
        




        public static void RunTransferTik(string idEmplKto)
        {
            TransferFormTik Trans = new TransferFormTik(idEmplKto);
            Trans.Show();
        }
    }
    public class clEventTickets
    {
        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        public string id { get; set; }
        public string id_Bilet { get; set; }
        public string id_Empl { get; set; }
        public string id_Client { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Status { get; set; }
        public long? NomOper { get; set; }
        public Double Price { get; set; }
        public string Id_CategoryOper { get; set; }
        public string Id_ParentTick { get; set; }
        // Дополнительно
        public string Id_Seria { get; set; }
        public string Id_Empl_Komy { get; set; }
        public clTickeks Tickets { get; set; }


        public clEventTickets()
        {
            this.Month = 0;
            this.Year = 0;
            this.Price = 0.00;
            this.Id_CategoryOper = null;
            this.Id_ParentTick = null;
            this.id_Client = null;
            this.NomOper = null;
            this.Status = 0;
            this.Tickets = new clTickeks();
        }
    
        public clEventTickets(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataEventTIcketsToIDtik]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.id = reader["id"].ToString();
                this.id_Bilet = reader["idBilet"].ToString();
                this.Id_CategoryOper = reader["idCatOper"].ToString();
                this.id_Client = reader["idclient"].ToString();
                this.id_Empl = reader["idempl"].ToString();
                this.Id_ParentTick = reader["idParent"].ToString();
                this.Month = Convert.ToInt32(reader["idMon"].ToString());
                this.Year = Convert.ToInt32(reader["idYear"].ToString());
                this.Price = Convert.ToDouble(reader["Price"].ToString());
                this.Status = Convert.ToInt32(reader["idstat"].ToString());
                this.NomOper = Convert.ToInt64(reader["nomoper"].ToString());
            }
            else MessageBox.Show("Пустой запрос!");
            connection.Close();

            this.Tickets = new clTickeks(this.id_Bilet);

        }
        public void InsertEvent()
        {
            // Основной набор перемещения билетов (Перенос, Списание)
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertEventTickeks]";
            Command.Parameters.Add("@id_Bilet", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id_Bilet"].Value = new Guid(this.id_Bilet);
            Command.Parameters.Add("@id_Empl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id_Empl"].Value = new Guid(this.Id_Empl_Komy);
            Command.Parameters.Add("@Status", SqlDbType.Int);
            Command.Parameters["@Status"].Value = this.Status;
            // Продажа
            if (this.id_Client != null)
            {
                Command.Parameters.Add("@id_Client", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id_Client"].Value = new Guid( this.id_Client);
                Command.Parameters.Add("@idcatoper", SqlDbType.UniqueIdentifier);
                Command.Parameters["@idcatoper"].Value = new Guid( this.Id_CategoryOper);
                Command.Parameters.Add("@priceoper", SqlDbType.Float);
                Command.Parameters["@priceoper"].Value = this.Price;
                Command.Parameters.Add("@Month", SqlDbType.Int);
                Command.Parameters["@Month"].Value = this.Month;
                Command.Parameters.Add("@Year", SqlDbType.Int);
                Command.Parameters["@Year"].Value = this.Year;
                Command.Parameters.Add("@nomoper", SqlDbType.Int);
                Command.Parameters["@nomoper"].Value = this.NomOper;
            }
            // Выдача дубликата
            if (this.Id_ParentTick !=null)
            {
                Command.Parameters.Add("@idparBil", SqlDbType.UniqueIdentifier);
                Command.Parameters["@idparBil"].Value = new Guid( this.Id_ParentTick);
            }
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }

    }
    public class clCanceledTickets
    {
        string idEvent { get; set; }
        bool isCancel { get; set; }

        void Operation_Update_EventTickets()
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[UpdateIsCancelToEvent]";
            Command.Parameters.Add("@idEvent", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idEvent"].Value = new Guid(this.idEvent);
            Command.Parameters.Add("@isCancel", SqlDbType.Bit);
            Command.Parameters["@isCancel"].Value = Convert.ToInt32(this.isCancel);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateIsCanceledToTickets(string idEven,bool isCancel)
        {
            clCanceledTickets tik = new clCanceledTickets();
            tik.idEvent = idEven;
            tik.isCancel = isCancel;
            tik.Operation_Update_EventTickets();
        }




    }




    public class clTickeks
    {

        string id { get; set; }
        string Number { get; set; }
        string IdSeria { get; set; }

        public clTickeks() { } //Пустой конструктор...


        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        public clTickeks(string idBilet)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataTicketsToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(idBilet);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.id = idBilet;
                this.IdSeria = reader["id_Series"].ToString();
                this.Number = reader["Number"].ToString();
            }
            else MessageBox.Show("Пустой запрос!");
            connection.Close();
        }

        public string GetFullName()
        {
            clSeries se = new clSeries(this.IdSeria);
            return se.Name + this.Number;
        }
        








    }
}
