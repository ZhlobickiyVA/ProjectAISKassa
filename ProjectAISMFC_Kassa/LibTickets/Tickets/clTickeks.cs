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
    /* 
     
         
         
     */
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
                this.Id_CategoryOper = reader["CatOper"].ToString();
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
                Command.Parameters["@id_Client"].Value = this.id_Client;
                Command.Parameters.Add("@idcatoper", SqlDbType.UniqueIdentifier);
                Command.Parameters["@idcatoper"].Value = this.Id_CategoryOper;
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
                Command.Parameters.Add("@idparBil", SqlDbType.Int);
                Command.Parameters["@idparBil"].Value = this.Status;
            }
            connection.Open();
                Command.ExecuteNonQuery();
            connection.Close();
        }

    }





    public class clTickeks
    {

        public string id { get; set; }
        public string id_Bilet { get; set; }
        public string id_Seria { get; set; }
        public string Number { get; set; }
        public string id_Empl { get; set; }
        public string id_Client { get; set; }
        public DateTime DateOperation { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string id_BiletParent { get; set; }
        public int Status { get; set; }
        public bool triger { get; set; }
        public long NomerOperation { get; set; }
        public float PriceOperation { get; set; }
        public string id_CatOperation { get; set; }



        public clTickeks() { } //Пустой конструктор...






        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;





















        //------------------------------------------------------------------------------------------------------------------------------------        




        // Для нового АРМ Бухгалтера










        // --------------------------------------------------------------------------------------------------------------------






        public void GetListGroupTik_(ComboBox sender)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectGroupTik]";

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "Name";
            sender.ValueMember = "id";



            connection.Close();
            sender.Select();

        }

        public void GetListTickeks_(DataGridView sender, BindingNavigator sender2, string series, string idEmpl, Int32 status, Int32 level, DateTime bdate, DateTime edate, int page, int count)
        {

            sender.Columns.Clear();

            if (sender.Rows.Count != 0) sender.Rows.Clear();

            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTickeks]";

            Command.Parameters.Add("@series", SqlDbType.NVarChar, 40);
            Command.Parameters["@series"].Value = series;

            Command.Parameters.Add("@idEmpl", SqlDbType.UniqueIdentifier);

            Command.Parameters["@idEmpl"].Value = new Guid(idEmpl);


            Command.Parameters.Add("@status", SqlDbType.Int);
            Command.Parameters["@status"].Value = status;

            Command.Parameters.Add("@Level", SqlDbType.Int);
            Command.Parameters["@level"].Value = level;

            Command.Parameters.Add("@bdate", SqlDbType.DateTime);
            Command.Parameters["@bdate"].Value = bdate.Date;

            Command.Parameters.Add("@edate", SqlDbType.DateTime);
            Command.Parameters["@edate"].Value = edate.Date;

            Command.Parameters.Add("@page", SqlDbType.Int);
            Command.Parameters["@page"].Value = page;

            Command.Parameters.Add("@count", SqlDbType.Int);
            Command.Parameters["@count"].Value = count;

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);
            connection.Close();

            BindingSource bs1 = new BindingSource();
            bs1.DataSource = ds.Tables[0].DefaultView;

            sender.DataSource = bs1;

            if (sender2 != null) sender2.BindingSource = bs1;

            sender.Columns[0].Visible = false;
            sender.Columns[1].Visible = false;
            //sender.Columns[4].Visible = false;
            //sender.Columns[5].Visible = false;
            sender.Columns[3].Width = 200;
            clSeries.RepaintCellgrid(sender, 2, 1);
            sender.Select();
        }

        public void GetListTickeks_(DataGridView sender, char[] stringsql)
        {


            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.Text;
            Command.CommandText = new string(stringsql);

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);
            connection.Close();

            BindingSource bs1 = new BindingSource();
            bs1.DataSource = ds.Tables[0].DefaultView;

            sender.DataSource = bs1;

            sender.Columns[0].Visible = false;
            sender.Columns[1].Visible = false;
            sender.Columns[3].Width = 200;

            clSeries ser = new clSeries();

            for (int i = 0; i < sender.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = sender.Rows[i];

                row.Cells[2].Style.BackColor = clSeries.getColorFromChar(row.Cells[1].Value.ToString());

            }

            sender.Select();


        }
        public void GetListPrice(DataGridView sender, string id)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectPriceFromCat]";

            Command.Parameters.Add("@id", SqlDbType.NVarChar, 50);
            Command.Parameters["@id"].Value = id;

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;
            sender.Columns[0].Visible = false;
            connection.Close();

        }


        public void GetListTickeksToClient(DataGridView sender, string id)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTickeksToCli]";

            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;
            sender.Columns[0].Visible = false;
            sender.Columns[1].Visible = false;

            sender.Columns[2].Width = 50;
            sender.Columns[3].Width = 120;
            sender.Columns[4].Width = 120;
            sender.Columns[5].Width = 70;
            sender.Columns[6].Width = 70;

            connection.Close();


            clSeries ser = new clSeries();

            for (int i = 0; i < sender.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = sender.Rows[i];

                row.Cells[2].Style.BackColor = clSeries.getColorFromChar(row.Cells[1].Value.ToString());

            }

        }



        public void GetListTickeksForCal(DataGridView sender, int idtrig, string idempl, int status, int indate, DateTime bdate, DateTime edate)
        {


            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTickeksToClear]";


            Command.Parameters.Add("@idtrig", SqlDbType.Bit);
            Command.Parameters["@idtrig"].Value = idtrig;

            Command.Parameters.Add("@idempl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idempl"].Value = new Guid(idempl);

            Command.Parameters.Add("@status", SqlDbType.Int);
            Command.Parameters["@status"].Value = status;

            Command.Parameters.Add("@indate", SqlDbType.Int);
            Command.Parameters["@indate"].Value = indate;

            Command.Parameters.Add("@bdate", SqlDbType.DateTime);
            Command.Parameters["@bdate"].Value = bdate;

            Command.Parameters.Add("@edate", SqlDbType.DateTime);
            Command.Parameters["@edate"].Value = edate;


            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);
            connection.Close();

            BindingSource bs1 = new BindingSource();
            bs1.DataSource = ds.Tables[0].DefaultView;

            sender.DataSource = bs1;

            sender.Columns[0].Visible = false;
            sender.Columns[1].Visible = false;
            sender.Columns[3].Width = 200;


            clSeries ser = new clSeries();

            for (int i = 0; i < sender.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = sender.Rows[i];

                row.Cells[2].Style.BackColor = clSeries.getColorFromChar(row.Cells[1].Value.ToString());

            }

            sender.Select();


        }



        public void GetListTikToDoub(ListBox sender, string id)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTikPrToDoub]";

            Command.Parameters.Add("@cli", SqlDbType.UniqueIdentifier);
            Command.Parameters["@cli"].Value = new Guid(id);

            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();

            data.Fill(ds);

            sender.DataSource = ds.Tables[0].DefaultView;


            sender.DisplayMember = "Name";
            sender.ValueMember = "id";
            if (sender.Items.Count != 0) sender.SelectedIndex = 0;
            connection.Close();


        }
    }

}
