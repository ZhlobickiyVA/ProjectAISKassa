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
    public class clGetViewTickets
    {
        public string idEmpl { get; set; }
        public string idSer { get; set; }
        public int status { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public DateTime DateB { get; set; }
        public DateTime DateE { get; set; }
        public int Level { get; set; }
        public bool isCancel { get; set; }


        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        public clGetViewTickets()

        {
            this.DateB = Convert.ToDateTime("01.01." + DateTime.Now.Year.ToString());
            this.DateE = Convert.ToDateTime("31.12." + DateTime.Now.Year.ToString());
            this.idSer = "0";
            this.month = 0;
            this.year = 0;
            this.status = -1;
            this.isCancel = false;
        } 



        class MasTik
        {
            public string ser { get; set; }
            public int tik { get; set; }
            public MasTik(string seria, int teckets)
            { ser = seria; tik = teckets; }
        }
        public static string getseria(string s)
        { return s[0].ToString() + s[1].ToString(); }
        public static void addrowgroup(DataTable sender, string seria, int tiks, int tikpo)
        {
            sender.Rows.Add("", clSeries.GetColorToName(seria), "", seria, tiks.ToString("D8"), tikpo.ToString("D8"));
        }
        public DataTable GetGroupViewGrid()
        {
            List<MasTik> list = new List<MasTik>();
            DataTable grid = new DataTable();
            DataTable sender = GetListTickeks();

            if (sender.Rows.Count != 0)
            {
                grid.Rows.Clear();
                grid.Columns.Clear();
                grid.Columns.Add("id");
                grid.Columns.Add("ColorName");
                grid.Columns.Add("Color");
                grid.Columns.Add("Ser");
                grid.Columns.Add("S");
                grid.Columns.Add("PO");


                for (int i = 0; i <= sender.Rows.Count - 1; i++)
                {
                    string ser = getseria(sender.Rows[i].ItemArray[3].ToString());
                    int tiks = Convert.ToInt32(sender.Rows[i].ItemArray[3].ToString().Remove(0, 2));
                    MasTik mas = new MasTik(ser, tiks);
                    list.Add(mas);
                }


                int start, stop;
                string startser, stopser;
                start = list[0].tik;
                startser = list[0].ser.ToString();
                stop = start;
                stopser = startser.ToString();
                for (int i = 1; i <= list.Count - 1; i++)
                {
                    if (startser == list[i].ser.ToString())
                    {
                        stop++;
                        if (stop != list[i].tik)
                        {
                            addrowgroup(grid, startser, start, list[i - 1].tik);
                            start = list[i].tik;
                            startser = list[i].ser.ToString();
                            stop = start;
                            stopser = startser;
                        }
                    }
                    else
                    {
                        addrowgroup(grid, startser, start, list[i - 1].tik);
                        start = list[i].tik;
                        startser = list[i].ser.ToString();
                        stop = start;
                        stopser = startser;
                    }
                    if (i == list.Count - 1)
                        if (start == stop) addrowgroup(grid, startser, start, stop);
                        else addrowgroup(grid, startser, start, list[i].tik);
                }
                if (list.Count() == 1) addrowgroup(grid, startser, start, stop);
            }
            list.Clear();

            return grid;
        }
        public DataTable GetListTickeks()
        {
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTickeksVer2]";
            Command.Parameters.Add("@series", SqlDbType.NVarChar, 40);
            Command.Parameters["@series"].Value = this.idSer;
            Command.Parameters.Add("@idEmpl", SqlDbType.NVarChar, 40);
            Command.Parameters["@idEmpl"].Value = this.idEmpl;
            Command.Parameters.Add("@status", SqlDbType.Int);
            Command.Parameters["@status"].Value = this.status;
            Command.Parameters.Add("@Level", SqlDbType.Int);
            Command.Parameters["@level"].Value = this.Level;
            Command.Parameters.Add("@bdate", SqlDbType.DateTime);
            Command.Parameters["@bdate"].Value = this.DateB;
            Command.Parameters.Add("@edate", SqlDbType.DateTime);
            Command.Parameters["@edate"].Value = this.DateE;
            Command.Parameters.Add("@month", SqlDbType.Int);
            Command.Parameters["@month"].Value = this.month;
            Command.Parameters.Add("@year", SqlDbType.Int);
            Command.Parameters["@year"].Value = this.year;
            Command.Parameters.Add("@isCancel", SqlDbType.Bit);
            Command.Parameters["@isCancel"].Value = Convert.ToInt32(this.isCancel);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            connection.Close();
            data.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable GetListTickeksBeetwen(string idSeria,int Status,string Begin,string End)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataTickBetween]";
            Command.Parameters.Add("@idSeria", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idSeria"].Value = new Guid(idSeria);
            Command.Parameters.Add("@Status", SqlDbType.Int);
            Command.Parameters["@Status"].Value = Status;
            Command.Parameters.Add("@Begin", SqlDbType.NVarChar,10);
            Command.Parameters["@Begin"].Value = Begin;
            Command.Parameters.Add("@End", SqlDbType.NVarChar,10);
            Command.Parameters["@End"].Value = End;
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            connection.Close();
            data.Fill(ds);
            return ds.Tables[0];
        }

        public static DataTable GetListTicketsToIdClient(string idClient, int Mon = 0, int Year = 0)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[SelectTickeksToCli]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(idClient);
            Command.Parameters.Add("@Year", SqlDbType.Int);
            Command.Parameters["@Year"].Value = Year;
            Command.Parameters.Add("@Month", SqlDbType.Int, 10);
            Command.Parameters["@Month"].Value = Mon;
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            connection.Close();
            data.Fill(ds);
            return ds.Tables[0];
        }



        public DataTable GetGroupViewGridVer2()
        {

            return null;
        }


        public static DataTable GetDiapazonToArray(DataTable mas, int indCol)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("S");
            Table.Columns.Add("PO");
            int S, PO;
            int MaxValue = Convert.ToInt32(mas.Rows[mas.Rows.Count - 1].ItemArray[indCol].ToString());
            int MinValue = Convert.ToInt32(mas.Rows[0].ItemArray[indCol].ToString());
            int Pos = MinValue;
            int index = 0;
            S = Convert.ToInt32(mas.Rows[0].ItemArray[indCol]);
            while (Pos <= MaxValue)
            {
                if ((Pos != Convert.ToInt32(mas.Rows[index].ItemArray[indCol].ToString())))
                {
                    PO = Convert.ToInt32(mas.Rows[index - 1].ItemArray[indCol].ToString());
                    Table.Rows.Add(S, PO);
                    Pos = Convert.ToInt32(mas.Rows[index].ItemArray[indCol].ToString());
                    S = Convert.ToInt32(mas.Rows[index].ItemArray[indCol].ToString()); ;
                }
                Pos++;
                index++;
                if (!(Pos <= MaxValue))
                {
                    PO = Convert.ToInt32(mas.Rows[mas.Rows.Count - 1].ItemArray[indCol].ToString()); ;
                    Table.Rows.Add(S, PO);
                }
            }
            return Table;
        }




    }
}
