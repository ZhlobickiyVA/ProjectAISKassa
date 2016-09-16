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
    public class clControlSer
    {

        public string id { get; set; }
        public string id_Series { get; set; }
        public int Mon { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }

        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command = new SqlCommand();

        public clControlSer() { } //Пустой конструктор

        public clControlSer(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataControlSeria]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                this.id_Series = reader["id_Series"].ToString();
                this.Mon = Convert.ToInt32(reader["Mon"].ToString());
                this.BeginDate = Convert.ToDateTime(reader["bdate"].ToString()).Date;
                this.EndDate = Convert.ToDateTime(reader["edate"].ToString()).Date;
                this.Active = Convert.ToBoolean(reader["Active"].ToString());                   
            }
            else MessageBox.Show("Пустой запрос! Запись не найдена.");
            connection.Close();
        }
        public static void RunControlSer()
        {
            ContPriceSer ser = new ContPriceSer();
            ser.Show();
        }

        public static void CreateControlSer()
        {
            clControlSer con = new clControlSer();
            RedControl red = new RedControl();
            if (red.ShowDialog() == DialogResult.OK)
            {
                con = red.GetData();
                con.Operatopn_Add_ControlSer();
            }
        }

        public static void UpdateControlSer(string id)
        {
            clControlSer con = new clControlSer();
            RedControl red = new RedControl(id);
            if (red.ShowDialog() == DialogResult.OK)
            {
                con = red.GetData();
                con.Operation_Update_ControlSer();
            }
        }

        public static void DeleteControlSer(string id)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выбранное правило?", "Удаление правила!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clControlSer con = new clControlSer(id);
                con.Operation_Delete_ControlSer();
            }
        }


        public static DataTable GetControlSer()
        {
                SqlConnection connection = new SqlConnection(Connect.GetConn());
                SqlCommand Command = new SqlCommand();
                Command.Connection = connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[SelectControl]";
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = Command;
                DataSet ds = new DataSet();
                clSeries ser = new clSeries();
                data.Fill(ds);
                return ds.Tables[0];
        }


        void Operatopn_Add_ControlSer()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[InsertControl]";
            Command.Parameters.Add("@idser", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idser"].Value = new Guid(this.id_Series);
            Command.Parameters.Add("@mon", SqlDbType.Int);
            Command.Parameters["@mon"].Value = this.Mon;
            Command.Parameters.Add("@edate", SqlDbType.DateTime);
            Command.Parameters["@edate"].Value = this.EndDate.Date;
            Command.Parameters.Add("@bdate", SqlDbType.DateTime);
            Command.Parameters["@bdate"].Value = this.BeginDate.Date;
            Command.Parameters.Add("@act", SqlDbType.Bit);
            Command.Parameters["@act"].Value = Convert.ToInt32( this.Active);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();                        
        }

        void Operation_Update_ControlSer()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[updateControl]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            Command.Parameters.Add("@idser", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idser"].Value = new Guid(this.id_Series);
            Command.Parameters.Add("@mon", SqlDbType.Int);
            Command.Parameters["@mon"].Value = this.Mon;
            Command.Parameters.Add("@bdate", SqlDbType.DateTime);
            Command.Parameters["@bdate"].Value = this.BeginDate.Date;
            Command.Parameters.Add("@edate", SqlDbType.DateTime);
            Command.Parameters["@edate"].Value = this.EndDate.Date;
            Command.Parameters.Add("@act", SqlDbType.Bit);
            Command.Parameters["@act"].Value = Convert.ToInt32( this.Active);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }

        void Operation_Delete_ControlSer()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[DeleteControl]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }
       
        //------------------------------------------------------------------------------------------------------------------------------------


        public static DataTable GetListSerPrice(string idempl) // для панели отображающая информацию о возможности продажи
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTikAccessToPrice]";
            Command.Parameters.Add("@empl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@empl"].Value = new Guid(idempl);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds.Tables[0];
        }
    }
}
