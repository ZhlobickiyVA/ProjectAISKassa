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
        public bool DoubTik { get; set; }
        public List<string> ListClientAdd { get; set; }
        public clSettingPrice()
        {
            ListClientAdd = new List<string>();
            DoubTik = false;
        }        
    }

    public class clOperation
    {


        SqlConnection connection = new SqlConnection(Connect.GetConn());
        SqlCommand Command;

        string idEmpl;

        public DataTable DataMonth { get; set; }
        public DataTable DataSeria { get; set; }
        public DataTable DataNumber { get; set; }

        int[] MasMonth;
        string[] MasSeria;
        string[] MasNumber;
        string[] MasIdClient;
        int[] MasYear;



        public clOperation(string idEmployess)
        {
            this.idEmpl = idEmployess;
            DataMonth = GetMonthToPrice();
            DataSeria = GetSeriaToPrice(Convert.ToInt32( DataMonth.Rows[0].ItemArray[0].ToString()));
            DataNumber = GetNumberTikToPrice(DataSeria.Rows[0].ItemArray[0].ToString());
        }

        public DataTable GetDefaultSeria(int idMon) { return DataSeria; }
        public DataTable GetDefaultNumber(string idSer) { return DataNumber; }

        public static void RunPriceTik(clEmployees empl, string idClient)
        {
            clClient cli = new clClient(idClient);
            if (cli.ListCategory.Count != 0)
            {
                Price pr = new Price(empl, cli);
                pr.ShowDialog();
            }
            else MessageBox.Show("У клиента, не назначены категории!");
        }

        // GetMonthToPrice param @idEmpl - Возврашает список месяц доступных для продажи
        // GetSeriaToPrice param @idEmpl, @MonPrice - Возврашает список серий доступных для продажи по заданному месяцу
        // GetNumberTikToPrice param @idEmpl,@idSeria - Возврашает список билетов доступных для продажи по заданной серии

        public DataTable GetMonthToPrice()
        {
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetMonthToPrice]";
            Command.Parameters.Add("@idEmpl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idEmpl"].Value = new Guid(this.idEmpl);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0];
            // id,Name
        }



        public DataTable GetSeriaToPrice(int MonPrice)
        {
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetSeriaToPrice]";
            Command.Parameters.Add("@idEmpl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idEmpl"].Value = new Guid(this.idEmpl);
            Command.Parameters.Add("@MonPrice", SqlDbType.Int);
            Command.Parameters["@MonPrice"].Value = MonPrice;
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0];
            // idSeria,Name
        }

        public DataTable GetNumberTikToPrice(string idSeria)
        {
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetNumberTikToPrice]";
            Command.Parameters.Add("@idEmpl", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idEmpl"].Value = new Guid(this.idEmpl);
            Command.Parameters.Add("@idSeria", SqlDbType.UniqueIdentifier);
            Command.Parameters["@idSeria"].Value = new Guid(idSeria);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0];
            // id,Number
        }


        public bool GetControlPrice(Control Sender,Label ReturnSender)
        {
            // Повторная продажа -- Красный
            // Два одинаковых билета -- Красный
            // Нехватка билетов -- Красный
            // Успех -- Зеленый

            int CountS = Sender.Controls.Count;

            MasMonth = new int[CountS];
            MasYear = new int[CountS];
            MasSeria = new string[CountS];
            MasNumber = new string[CountS];
            MasIdClient = new string[CountS];

            bool DoubPriceValid = true; // Повторная продажа проверка 
            bool DoubTik = false; // Повторяющиеся билеты
            bool CountControlPrice = false; // Нехватка билетов

            bool RetDoubPriceValid = false; // Повторная продажа проверка 
            bool RetDoubTik = false; // Повторяющиеся билеты
            bool RetCountControlPrice = false; // Нехватка билетов

            for (int i = 0; i <= CountS - 1; i++)
            {
                UPanel pan = (Sender.Controls[i] as UPanel);
                MasMonth[i] = Convert.ToInt32(pan.MonthCB.SelectedValue.ToString());
                MasSeria[i] = pan.SeriaCB.SelectedValue.ToString();
                MasNumber[i] = pan.NumberCB.SelectedValue.ToString();
                MasIdClient[i] = pan.IdClient;
                MasYear[i] = Convert.ToInt32(pan.Year);
            
            }
            // Определяем виды проверок
            if (CountS != 1) 
            { DoubTik = true; CountControlPrice = true; }


            // проверка на повторную продажу по заданным параметрам
            if (DoubPriceValid)
            {
                for (int i = 0; i <= CountS - 1; i++)
                {
                    if ((Sender.Controls[i] as UPanel).TypeTik != 3) // непроверяем и отсекаем испорченные
                    {
                        if ((clGetViewTickets.GetListTicketsToIdClient(MasIdClient[i], MasMonth[i], MasYear[i]).Rows.Count) == 0)
                        {
                            (Sender.Controls[i] as UPanel).ValidControl = 0;
                            (Sender.Controls[i] as UPanel).ResreshTypeTik();
                            
                        }
                        else
                        {
                            (Sender.Controls[i] as UPanel).ValidControl = 1;
                            (Sender.Controls[i] as UPanel).ResreshTypeTik();
                            RetDoubPriceValid = true;
                        }
                    }
                    else
                    {
                        (Sender.Controls[i] as UPanel).ValidControl = 2;
                        (Sender.Controls[i] as UPanel).ResreshTypeTik();
                    }
                }
            }
            // Проверка повторияющихся билетов

            if (DoubTik)
            {
                string Se;
                string Nu;

                for (int i = 0; i <= CountS - 1; i++)
                {
                    Se = MasSeria[i];
                    Nu = MasNumber[i];

                    

                    for (int j = i+1; j <= CountS - 1; j++)
                    {
                        if (Se == MasSeria[j] && Nu == MasNumber[j])
                        {
                            (Sender.Controls[j] as UPanel).ValidControl = 1;
                            (Sender.Controls[j] as UPanel).ResreshTypeTik();
                            RetDoubTik = true;
                        }
                    }

                    
                }


            }

            if (RetDoubPriceValid) { ReturnSender.Text = "Повтор продажи"; return false; }
            else
            if (RetDoubTik) { ReturnSender.Text = "Равные билеты"; return false; }
            else
            {
                ReturnSender.Text = "Успех";
                return true;
            }



            
        }

        

    }
}
