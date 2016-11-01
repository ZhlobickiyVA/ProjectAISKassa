using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibEmployees;
using LibClient;
using System.Windows.Forms;
using libCategory;
using ListAccess;
using ConnectLib;
using System.Data.SqlClient;
using System.Data;
using LibTickets;

namespace LibARM_Operator
{


    
    public class clSettingPrice
    {
    //    public bool DoubTik { get; set; }
    //    public List<string> ListClientAdd { get; set; }
    //    public clSettingPrice()
    //    {
    //        ListClientAdd = new List<string>();
    //        DoubTik = false;
    //    }        
    }

    public class clOperation
    {


    //    SqlConnection connection = new SqlConnection(Connect.GetConn());
    //    SqlCommand Command;

    //    string idEmpl;

    //    public DataTable DataMonth { get; set; }
    //    public DataTable DataSeria { get; set; }
    //    public DataTable DataNumber { get; set; }

    //    int[] MasMonth;
    //    string[] MasSeria;
    //    string[] MasNumber;
    //    string[] MasIdClient;
    //    int[] MasYear;



    //    public clOperation(string idEmployess)
    //    {
    //        this.idEmpl = idEmployess;
    //        DataMonth = GetMonthToPrice();
    //        DataSeria = GetSeriaToPrice(Convert.ToInt32( DataMonth.Rows[0].ItemArray[0].ToString()));
    //        DataNumber = GetNumberTikToPrice(DataSeria.Rows[0].ItemArray[0].ToString());
    //    }

    //    public DataTable GetDefaultSeria(int idMon) { return DataSeria; }
    //    public DataTable GetDefaultNumber(string idSer) { return DataNumber; }

    //    public static void RunPriceTik(clEmployees empl, string idClient)
    //    {
    //        clClient cli = new clClient(idClient);
    //        if (cli.ListCategory.Count != 0)
    //        {
    //            Price pr = new Price(empl, cli);
    //            pr.ShowDialog();
    //        }
    //        else MessageBox.Show("У клиента, не назначены категории!");
    //    }

    //    // GetMonthToPrice param @idEmpl - Возврашает список месяц доступных для продажи
    //    // GetSeriaToPrice param @idEmpl, @MonPrice - Возврашает список серий доступных для продажи по заданному месяцу
    //    // GetNumberTikToPrice param @idEmpl,@idSeria - Возврашает список билетов доступных для продажи по заданной серии

    //    public DataTable GetMonthToPrice()
    //    {
    //        Command = new SqlCommand();
    //        Command.Connection = connection;
    //        Command.CommandType = CommandType.StoredProcedure;
    //        Command.CommandText = "[GetMonthToPrice]";
    //        Command.Parameters.Add("@idEmpl", SqlDbType.UniqueIdentifier);
    //        Command.Parameters["@idEmpl"].Value = new Guid(this.idEmpl);
    //        SqlDataAdapter data = new SqlDataAdapter();
    //        data.SelectCommand = Command;
    //        DataSet ds = new DataSet();
    //        data.Fill(ds);
    //        connection.Close();
    //        return ds.Tables[0];
    //        // id,Name
    //    }



    //    public DataTable GetSeriaToPrice(int MonPrice)
    //    {
    //        Command = new SqlCommand();
    //        Command.Connection = connection;
    //        Command.CommandType = CommandType.StoredProcedure;
    //        Command.CommandText = "[GetSeriaToPrice]";
    //        Command.Parameters.Add("@idEmpl", SqlDbType.UniqueIdentifier);
    //        Command.Parameters["@idEmpl"].Value = new Guid(this.idEmpl);
    //        Command.Parameters.Add("@MonPrice", SqlDbType.Int);
    //        Command.Parameters["@MonPrice"].Value = MonPrice;
    //        SqlDataAdapter data = new SqlDataAdapter();
    //        data.SelectCommand = Command;
    //        DataSet ds = new DataSet();
    //        data.Fill(ds);
    //        connection.Close();
    //        return ds.Tables[0];
    //        // idSeria,Name
    //    }

    //    public DataTable GetNumberTikToPrice(string idSeria)
    //    {
    //        Command = new SqlCommand();
    //        Command.Connection = connection;
    //        Command.CommandType = CommandType.StoredProcedure;
    //        Command.CommandText = "[GetNumberTikToPrice]";
    //        Command.Parameters.Add("@idEmpl", SqlDbType.UniqueIdentifier);
    //        Command.Parameters["@idEmpl"].Value = new Guid(this.idEmpl);
    //        Command.Parameters.Add("@idSeria", SqlDbType.UniqueIdentifier);
    //        Command.Parameters["@idSeria"].Value = new Guid(idSeria);
    //        SqlDataAdapter data = new SqlDataAdapter();
    //        data.SelectCommand = Command;
    //        DataSet ds = new DataSet();
    //        data.Fill(ds);
    //        connection.Close();
    //        return ds.Tables[0];
    //        // id,Number
    //    }




        

    }
}
