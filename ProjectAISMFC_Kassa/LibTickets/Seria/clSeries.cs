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
    public class clSeries
    {

        public string id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;


        public clSeries() { } // Пустой конструктор

        public clSeries(string id)
        {//GetDataSeriaToID

            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataSeriaToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                this.Name = reader["Name"].ToString();
                this.Color = reader["Color"].ToString();
            }
            else MessageBox.Show("Пустой запрос! Запись не найдена.");
            connection.Close();
        }

        public static clSeries GetDataToName (string Name)
        {//GetDataSeriaToID
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;
            clSeries ser = new clSeries();
            ser.Name = Name;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataSeriaToName]";
            Command.Parameters.Add("@Name", SqlDbType.NVarChar,20);
            Command.Parameters["@Name"].Value = Name.Trim();
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                ser.id = reader["id"].ToString();
                ser.Color = reader["Color"].ToString();
            }
            else MessageBox.Show("Пустой запрос! Запись не найдена.");
            connection.Close();
            return ser;
        }




        public static void RunSpSeria()
        {
            spSeries ser = new spSeries();
            ser.Show();
        }

        public static void AddSeria()
        {
            RedSer ser = new RedSer();
            if (ser.ShowDialog() == DialogResult.OK)
            {
                clSeries s = new clSeries();
                s = ser.GetData();
                s.Operation_Add_Seria();
            }
        }

        public static void UpdateSeria(string id)
        {
            RedSer ser = new RedSer(id);
            if (ser.ShowDialog() == DialogResult.OK)
            {
                clSeries s = new clSeries();
                s = ser.GetData();
                s.Operation_Update_Seria();
            }
        }

        public static Color GetColorToID(string id)
        {
            clSeries S = new clSeries(id);
            return clSeries.getColorFromChar(S.Color.ToString());
        }

        public static string GetColor(string id)
        {
            clSeries ser = new clSeries(id);
            return ser.Color;
        }


        public static Color getColorFromChar(string str)
        {
            Int32 I = Convert.ToInt32(str);
            Color col = System.Drawing.Color.FromArgb(I);
            return System.Drawing.Color.FromArgb(col.A, col.R, col.G, col.B);
        }

        public static DataView GetListSeria()
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectSeries]";
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0].DefaultView;
        }

        public static void RepaintCellgrid(DataGridView sender, int CellsRepainIndex, int SourceCellindex)
        {
            DataGridViewRow row;
            for (int i = 0; i < sender.Rows.Count; i++)
            {
                row = new DataGridViewRow();
                row = sender.Rows[i];
                row.Cells[CellsRepainIndex].Style.BackColor = getColorFromChar(row.Cells[SourceCellindex].Value.ToString());
            }
        }


        public static DataTable GetListSeriesFromGroup(string idempl, int status)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectSeriesFromGroup]";
            Command.Parameters.Add("@idempl", SqlDbType.NVarChar, 40);
            Command.Parameters["@idempl"].Value = idempl;
            Command.Parameters.Add("@status", SqlDbType.Int);
            Command.Parameters["@status"].Value = status;
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }

        void Operation_Add_Seria()
        {
            try
            {
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[InsertSeries]";
                Command.Parameters.Add("@nameSer", SqlDbType.NVarChar, 50);
                Command.Parameters["@nameSer"].Value = this.Name;
                Command.Parameters.Add("@nameColor", SqlDbType.NVarChar, 100);
                Command.Parameters["@nameColor"].Value = this.Color;
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

        void Operation_Update_Seria()
        {
            try
            {
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[UpdateSeries]";
                Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
                Command.Parameters["@id"].Value = new Guid(this.id);
                Command.Parameters.Add("@nameSer", SqlDbType.NVarChar, 50);
                Command.Parameters["@nameSer"].Value = this.Name;
                Command.Parameters.Add("@nameColor", SqlDbType.NVarChar, 100);
                Command.Parameters["@nameColor"].Value = this.Color;
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

        void Operation_Delete_Seria()
        { }


        //-------------------------------------------------------------------------------------------------------------


        public static string GetColorToName(string name) // возвращает color по имени серии
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Connect.GetConn();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[GETCOLORtoNAme]";

            myCommand.Parameters.Add("@name", SqlDbType.NVarChar,10);
            myCommand.Parameters["@name"].Value = name;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.NChar;
            param.Size = 40;
            param.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(param);

            conn.Open();

            myCommand.ExecuteNonQuery();

            conn.Close();

            return myCommand.Parameters["@ret"].Value.ToString();

        }



        public void DeleteSeries()
        { }

        //SelectSeries
        public void GetListSeries(DataGridView sender)
        {
            
            
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectSeries]";

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);
            
            if (ds.Tables[0].Rows.Count != 0)
            {
            sender.DataSource = ds.Tables[0].DefaultView;
            sender.Columns[0].Name = "id";
            sender.Columns[0].Visible = false;
            sender.Columns[1].Name = "Name";
            sender.Columns[2].Name = "Colint";
            sender.Columns[3].Name = "ColorT";

                for (int i = 0; i < sender.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    row = sender.Rows[i];
                                        
                    row.Cells["ColorT"].Style.BackColor = getColorFromChar(row.Cells["Colint"].Value.ToString());
                }

            }
             connection.Close();

        }

        public void GetListSeries(ComboBox sender)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectSeries]";

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "Название";
            sender.ValueMember = "ids";

            sender.SelectedIndex = 0;
            sender.Select();
            connection.Close();

        }
        



        public void GetListSeriesFromGroup(DataGridViewComboBoxColumn sender, string idempl, int status)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectSeriesFromGroup]";

            Command.Parameters.Add("@idempl", SqlDbType.NVarChar, 40);
            Command.Parameters["@idempl"].Value = idempl;

            Command.Parameters.Add("@status", SqlDbType.Int);
            Command.Parameters["@status"].Value = status;

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "name";
            sender.ValueMember = "id";
                        
            connection.Close();

        }

        public void GetListSerEmplPrice(ComboBox sender,DateTime dat,string idempl,int month)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTikPrice]";

            Command.Parameters.Add("@dat", SqlDbType.DateTime);
            Command.Parameters["@dat"].Value = dat.Date;

            Command.Parameters.Add("@empl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@empl"].Value = new Guid(idempl);

            Command.Parameters.Add("@mon", SqlDbType.Int);
            Command.Parameters["@mon"].Value = month;

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "Name";
            sender.ValueMember = "id";

            sender.SelectedIndex = 0;
            sender.Select();
            connection.Close();

        }

        public void GetListMonth(ComboBox sender, DateTime dat, string idempl)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectMonthtoPrice]";

            Command.Parameters.Add("@dat", SqlDbType.DateTime);
            Command.Parameters["@dat"].Value = dat.Date;

            Command.Parameters.Add("@empl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@empl"].Value = new Guid(idempl);

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "mont";
            sender.ValueMember = "idmon";

            sender.SelectedIndex = 0;
            sender.Select();
            connection.Close();

        }

        public void GetListNUmberTikToPrice(ComboBox sender, string ser, string idempl)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectNumberTikTiPrice]";

            Command.Parameters.Add("@empl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@empl"].Value = new Guid(idempl);

            Command.Parameters.Add("@ser", SqlDbType.UniqueIdentifier);
            Command.Parameters["@ser"].Value = new Guid(ser);

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "Number";
            sender.ValueMember = "id";

            //sender.SelectedIndex = 0;
            sender.Select();
            connection.Close();

        }


    }
}
