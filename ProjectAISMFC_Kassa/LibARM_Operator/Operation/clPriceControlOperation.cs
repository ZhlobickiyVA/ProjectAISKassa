using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCategory;
using LibClient;
using LibEmployees;
using System.Data.SqlClient;
using System.Data;
using ConnectLib;
using ListAccess;
using UtilDLL;
using LibTickets;
using CashLib;

namespace LibARM_Operator
{
    public class clPriceControlOperation
    {
        // Forms
        Price FormPrice;
        FsettingPrice FormSettingPrice;
        // SettingPrice
        public bool AccessDoubTikResult { get; set; } = false;
        
        public clEmployees Employees;
        public List<clClient> ListClient;

        public clCateegory Category;

        public List<UPanel> Panel;
        public UpanelService ServicePanel;
        
        public DataTable DataTickets = new DataTable();
        
        //public delegate void EventHandler(object sender, EventArgs e);
        // Privat
        private string SelectCategoryID;
        // Control
        public ListBox ListCategory { set; get; }
        public Button ButtonSetting { set; get; }
        public Control FSender { get; set; }
        public Label SummaPrice { get; set; }
        public Label ControlLabel { get; set; }
        // Конструктор
        public clPriceControlOperation(string idClient, string idEmpl)
        {
            // Запоминаем данные нулевого клиента
            clClient CliZero = new clClient(idClient);
            ListClient = new List<clClient>();
            ListClient.Add(CliZero);
            // Заполняем данные сотрудника
            Employees = new clEmployees(idEmpl);
            DataTickets = GetListTicPriceToEmployees(idEmpl);
        }
        public static DataTable GetListTicPriceToEmployees(string idEmpl)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataTickPriceToIDempl]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(idEmpl);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            connection.Close();
            data.Fill(ds);
            return ds.Tables[0];
            // idMon,idSer,idNumber
        }
        public DataTable GetSubClientToClient(int type = 1)
        {
            clListAccess Lis = new clListAccess();
            Lis.id_Cat = Category.id;
            if (type == 1) Lis.id_Client = this.ListClient[0].id;
            if (type == 2) Lis.id_SubClient = this.ListClient[0].id;
            DateTime Dat = Connect.GetDateServer();
            Lis.Month = Dat.Month;
            Lis.Year = Dat.Year;

            return clListAccess.GetListAccess(Lis, type);
        }
        public static void RunPrice(string idClient, string idEmpl)
        {
            clPriceControlOperation Operation = new clPriceControlOperation(idClient, idEmpl);
            // если у клиента нет доступных категорий для продажи
            if (Operation.ListClient[0].ListCategory.Count != 0)
            {
                Operation.FormPrice = new Price(Operation.Employees, Operation);
                Operation.ButtonSetting.Enabled = false;
                Operation.ListCategory.SelectedIndexChanged += new System.EventHandler(Operation.ListCat_SelectedIndexChanged);
                Operation.ButtonSetting.Click += new System.EventHandler(Operation.SettingPrice);
                Operation.FSender.ControlAdded += new System.Windows.Forms.ControlEventHandler(Operation.ControlAdded);
                Operation.FSender.ControlRemoved += new System.Windows.Forms.ControlEventHandler(Operation.ControlAdded);

                Operation.FormPrice.ShowDialog();
            }
            else MessageBox.Show("У клиента, не назначены категории!");



        }
        public static void RunDoub(string idBilet)
        {
            Doub dou = new Doub(idBilet);
            dou.ShowDialog();
        }
        private void ControlAdded(object sender, ControlEventArgs e)
        {
            double Sum = 0;

            for (int i = 0; i <= FSender.Controls.Count - 1; i++)
            {
                if (FSender.Controls[i] is UPanel)
                {
                    if ((FSender.Controls[i] as UPanel).TypeTik != 3)
                    {
                        Sum += ((FSender.Controls[i] as UPanel).Price);
                    }
                }
            }
            this.SummaPrice.Text = Sum.ToString("C2");
            this.SummaPrice.Tag = Sum;
        }
        public void ListCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AccessDoubTikResult = false;
            while (this.ListClient.Count != 1) this.ListClient.RemoveAt(this.ListClient.Count - 1);
            if (SelectCategoryID != this.ListClient[0].ListCategory[((sender as ListBox).SelectedIndex)].ToString())
            {
                SelectCategoryID = this.ListClient[0].ListCategory[((sender as ListBox).SelectedIndex)].ToString();
                Category = new clCateegory(SelectCategoryID);
                FormPrice.infocat.Text = Category.Note;
                RefreshDataToSenderPanel();
            }
        }
        private void ClearControlSender()
        {
            bool flagIsp = false;
            bool ServicePanel = false;

            for (int i = 0; i <= FSender.Controls.Count - 1; i++)
            {
                Control co = new Control();
                co = FSender.Controls[i];
                if (co is UPanel && (co as UPanel).TypeTik == 3) flagIsp = true;
                if (co is UpanelService) ServicePanel = true;
            }

            // Если только сервисные
            if (ServicePanel && FSender.Controls.Count == 1) FSender.Controls.Clear();
            // Если нет испорченных и сервисных
            if (!ServicePanel && !flagIsp) FSender.Controls.Clear();
            // Если есть испорченные но нет сервисных
            if (flagIsp && !ServicePanel)
            {
                int i = 0;
                while (i <= FSender.Controls.Count - 1)
                {
                    if (FSender.Controls[i] is UPanel)
                    {
                        if ((FSender.Controls[i] as UPanel).TypeTik != 3)
                        {
                            FSender.Controls.RemoveAt(i);
                        }
                        else i++;
                    }
                }

            }
            // Если есть испорченные и сервисные
            if (flagIsp && ServicePanel)
            {
                int i = 0;
                while (i <= FSender.Controls.Count - 1)
                {
                    if (FSender.Controls[i] is UPanel)
                    {
                        if (((FSender.Controls[i] as UPanel).TypeTik != 3))
                        {
                            FSender.Controls.RemoveAt(i);
                        }
                        else i++;
                    }
                    if (FSender.Controls[i] is UpanelService) FSender.Controls.RemoveAt(i);
                    else i++;
                }
            }




        }
        private void RefreshDataToSenderPanel()
        {
            if (FSender.Controls.Count != 0) ClearControlSender(); // Очистка поля
            // Флаг кнопки
            bool trig = true;
            // Доступны списки разрешения для категории 
            this.ButtonSetting.Enabled = false;
            if (Category.flag)
            {
                FormSettingPrice = new FsettingPrice(this);
                // Контроль по клиенту - Опекуны
                if (Category.TypeClient == 1)
                {
                    DataTable tab = new DataTable();
                    tab = GetSubClientToClient(1);
                    if (tab.Rows.Count == 0)
                    {
                        trig = false;
                        GetInfoPanelToFsender();
                    }
                    else
                        this.ButtonSetting.Enabled = true;
                }
                // Контроль по суб клиенту - Сироты
                if (Category.TypeClient == 2)
                {
                    DataTable tab = new DataTable();
                    tab = GetSubClientToClient(2);
                    if (tab.Rows.Count == 0)
                    {
                        trig = false;
                        GetInfoPanelToFsender();
                    }
                }
            }
            // Доступен дополнительный билет
            if (Category.AccesDoubTik)
            {
                this.ButtonSetting.Enabled = true;
                FormSettingPrice = new FsettingPrice(this);
            }
            if (trig) ViewListTicketsToPrice();
        }
        private void ViewListTicketsToPrice()
        {
            ClearControlSender();


            for (int i = 0; i <= this.ListClient.Count - 1; i++)
            {
                if (this.ListClient[i].TagTypeClient == 3) GetPriceTikToFsender(this.ListClient[i], 11);
                else
                if (this.ListClient[i].TagTypeClient == 2) GetPriceTikToFsender(this.ListClient[i], 12);
                else GetPriceTikToFsender(this.ListClient[i]);
            }

        }
        public void SettingPrice(object sender, EventArgs e)
        {
            if (FormSettingPrice.ShowDialog() == DialogResult.OK)
            {
                ViewListTicketsToPrice();
                this.ReNumberTicketsToControl();
            }
        }
        public void GetPriceTikToFsender(clClient Cli, int Type = 1, string idParentMonth = "")
        {
            try
            {
                UPanel Pan = new UPanel(this);
                Pan.Client = Cli;
                Pan.TypeTik = Type;
                Pan.DataMonth = this.GetListMonth();
                Pan.DataSeria = this.GetListSeria(Convert.ToInt32(Pan.DataMonth.Rows[0].ItemArray[0]));
                Pan.DataNumber = this.GetListNumber(Convert.ToInt32(Pan.DataMonth.Rows[0].ItemArray[0]), Pan.DataSeria.Rows[0].ItemArray[0].ToString());
                Pan.idParentMonth = idParentMonth;
                Pan.LoadUPanel();
                Pan.MonthCB.Select();
                FSender.Controls.Add(Pan);
            }
            catch { }
        }
        void GetInfoPanelToFsender()
        {
            UpanelService ser = new UpanelService();
            ser.AddButton.Click += new System.EventHandler(this.AddClientToList);
            FSender.Controls.Add(ser);
        }
        public void AddClientToList(object sender, EventArgs e)
        {
            clListAccess list = new clListAccess();
            list.id_Cat = Category.id;
            if (Category.TypeClient == 1) list.id_Client = this.ListClient[0].id;
            if (Category.TypeClient == 2) list.id_SubClient = this.ListClient[0].id;
            DateTime dat = Connect.GetDateServer();
            list.Month = dat.Month;
            list.Year = dat.Year;
            clListAccess.AddList(list);
            RefreshDataToSenderPanel();

        }
        //

        // 
        public DataTable GetListMonth()
        {
            var query = from table in this.DataTickets.AsEnumerable()
                        group table by table.Field<int>("idMon") into MonList
                        select new
                        {
                            MonKey = MonList.Key

                        };
            DataTable Month = new DataTable();
            Month.Columns.Add("id");
            Month.Columns.Add("Name");
            foreach (var m in query)
            {
                string indexMon = m.MonKey.ToString();
                Month.Rows.Add(indexMon, CLUtils.GetListMonth()[Convert.ToInt32(indexMon)]);
            }

            return Month;
        }
        public DataTable GetListSeria(int IdMon)
        {
            var dbSeries = from Ser in this.DataTickets.AsEnumerable()
                           where Ser.Field<int>("idMon") == IdMon
                           group Ser by Ser.Field<String>("idSer") into SerList
                           select new
                           {
                               idSer = SerList.Key
                           };
            DataTable dbS = new DataTable();
            dbS.Columns.Add("id");
            dbS.Columns.Add("Name");

            foreach (var m in dbSeries)
            {
                string indexSer = m.idSer.ToString();
                dbS.Rows.Add(indexSer, new clSeries(indexSer).Name);
            }


            return dbS;
        }
        public DataTable GetListNumber(int idMon, string idSer)
        {
            var Number = (from table in this.DataTickets.AsEnumerable()
                          where table.Field<int>("idMon") == idMon && table.Field<String>("idSer") == idSer
                          orderby table["Number"]
                          select new
                          {
                              id = table["idNumber"],
                              Name = table["Number"]
                          }
                          );
            DataTable dbNumber = new DataTable();
            dbNumber.Columns.Add("id");
            dbNumber.Columns.Add("Name");
            foreach (var m in Number)
            {
                dbNumber.Rows.Add(m.id, m.Name);
            }

            return dbNumber;
        }
        public void ReNumberTicketsToControl()
        {


            int countseria = (FSender.Controls[0] as UPanel).DataSeria.Rows.Count;



            for (int i = 0; i <= countseria - 1; i++)
            {
                int ind = 0;

                for (int j = 0; j <= FSender.Controls.Count - 1; j++)
                {
                    Control co = FSender.Controls[j];
                    if (co is UPanel)
                    {
                        if ((co as UPanel).SeriaCB.SelectedIndex == i)
                        {
                            (co as UPanel).NumberCB.SelectedIndex = ind;
                            ind++;
                        }
                    }


                }



            }




        }
        public bool GetControlPrice(bool ControlDoubPrice = true)
        {
            // Повторная продажа -- Красный
            // Два одинаковых билета -- Красный
            // Нехватка билетов -- Красный
            // Успех -- Зеленый
            int CountS = FSender.Controls.Count;
            int[] MasMonth = new int[CountS];
            int[] MasYear = new int[CountS];
            string[] MasSeria = new string[CountS];
            string[] MasNumber = new string[CountS];
            string[] MasIdClient = new string[CountS];
            bool DoubPriceValid = ControlDoubPrice; // Повторная продажа проверка 
            bool DoubTik = false; // Повторяющиеся билеты
            bool CountControlPrice = false; // Нехватка билетов
            bool RetDoubPriceValid = false; // Повторная продажа проверка 
            bool RetDoubTik = false; // Повторяющиеся билеты
            bool RetCountControlPrice = false; // Нехватка билетов
            for (int i = 0; i <= CountS - 1; i++)
            {
                UPanel pan = (FSender.Controls[i] as UPanel);
                MasMonth[i] = Convert.ToInt32(pan.MonthCB.SelectedValue.ToString());
                MasSeria[i] = pan.SeriaCB.SelectedValue.ToString();
                MasNumber[i] = pan.NumberCB.SelectedValue.ToString();
                MasIdClient[i] = pan.Client.id;
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
                    if ((FSender.Controls[i] as UPanel).TypeTik != 3) // непроверяем и отсекаем испорченные
                    {
                        if ((clGetViewTickets.GetListTicketsToIdClient(MasIdClient[i], MasMonth[i], MasYear[i]).Rows.Count) == 0)
                        {
                            (FSender.Controls[i] as UPanel).ValidControl = 0;
                            (FSender.Controls[i] as UPanel).ResreshTypeTik();

                        }
                        else
                        {
                            (FSender.Controls[i] as UPanel).ValidControl = 1;
                            (FSender.Controls[i] as UPanel).ResreshTypeTik();
                            RetDoubPriceValid = true;
                        }
                    }
                    else
                    {
                        (FSender.Controls[i] as UPanel).ValidControl = 2;
                        (FSender.Controls[i] as UPanel).ResreshTypeTik();
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
                    for (int j = i + 1; j <= CountS - 1; j++)
                    {
                        if (Se == MasSeria[j] && Nu == MasNumber[j])
                        {
                            (FSender.Controls[j] as UPanel).ValidControl = 1;
                            (FSender.Controls[j] as UPanel).ResreshTypeTik();
                            RetDoubTik = true;
                        }
                    }
                }
            }
            if (RetDoubPriceValid) { this.ControlLabel.Text = "Повтор продажи"; return false; }
            else
            if (RetDoubTik) { this.ControlLabel.Text = "Равные билеты"; return false; }
            else
            {
                this.ControlLabel.Text = "Успех";
                return true;
            }
        }

        public void PriceTik()
        {
            int PriceTik = 0;
            int IspTik = 0;
            if (this.GetControlPrice())
            {
                if (MessageBox.Show("Вы уверенны, что хотите совершить операцию?", "Проверка пройдена!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clEventTickets Event = new clEventTickets();
                    Event.Id_Empl_Komy = this.Employees.id;
                    Event.Id_CategoryOper = this.Category.id;
                    Event.NomOper = clFix.GetFix();

                    for (int i=0;i<=FSender.Controls.Count-1;i++)
                    {
                        Control co = FSender.Controls[i];
                        if (co is UPanel)
                        {
                            Event.id_Client = (co as UPanel).Client.id;
                            Event.Price = (co as UPanel).Price;
                            Event.id_Bilet = (co as UPanel).NumberCB.SelectedValue.ToString();
                            Event.Month = Convert.ToInt32( (co as UPanel).MonthCB.SelectedValue.ToString());
                            Event.Year = Convert.ToInt32((co as UPanel).Year.ToString());
                            if ((co as UPanel).TypeTik == 3)
                            { Event.Status = 3; IspTik++; Event.id_Client = null; }
                            else
                            { Event.Status = 1; PriceTik++; }
                            Event.InsertEvent();     
                        }
                    }
                    clKassa Kas = new clKassa();
                    Kas.NomOper = Event.NomOper;
                    Kas.idEmpl = Event.Id_Empl_Komy;
                    Kas.Debet = Convert.ToDouble( SummaPrice.Tag.ToString());
                    Kas.Kredit = 0;
                    Kas.addEventMoneytoKass();

                    MessageInfo info = new MessageInfo();
                    info.Lin.Add("Операция успешно произведена!");
                    info.Lin.Add("Продано билетов: " + PriceTik.ToString() + " шт.");
                    info.Lin.Add("Испорчено билетов: " + IspTik.ToString() + " шт.");
                    info.Lin.Add("Сумма операции составила: " + SummaPrice.Text);

                    if (info.ShowDialog() == DialogResult.OK)
                    {
                        (FSender.TopLevelControl as Form).Close();
                    }

                }

            }


        }

        public void DoubTik(string ParentTickets)
        {
            int PriceTik = 0;
            int IspTik = 0;
            if (this.GetControlPrice(false))
            {
                if (MessageBox.Show("Вы уверенны, что хотите совершить операцию?", "Проверка пройдена!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clEventTickets Event = new clEventTickets();
                    Event.Id_Empl_Komy = this.Employees.id;
                    Event.Id_CategoryOper = this.Category.id;
                    Event.NomOper = 0;

                    for (int i = 0; i <= FSender.Controls.Count - 1; i++)
                    {
                        Control co = FSender.Controls[i];
                        if (co is UPanel)
                        {
                            Event.id_Client = (co as UPanel).Client.id;
                            Event.Price = 0;
                            Event.id_Bilet = (co as UPanel).NumberCB.SelectedValue.ToString();
                            Event.Month = Convert.ToInt32((co as UPanel).MonthCB.SelectedValue.ToString());
                            Event.Year = Convert.ToInt32((co as UPanel).Year.ToString());
                            
                            if ((co as UPanel).TypeTik == 3) { Event.Status = 3; Event.id_Client = null; IspTik++; }
                            else
                            {
                                Event.Status = 2;
                                Event.Id_ParentTick = ParentTickets;
                                PriceTik++;
                            }
                            Event.InsertEvent();
                            Event.Id_ParentTick = null;
                        }
                    }


                    MessageInfo info = new MessageInfo();
                    info.Lin.Add("Операция успешно произведена!");
                    info.Lin.Add("Выдано дубликатов билетов: " + PriceTik.ToString() + " шт.");
                    info.Lin.Add("Испорчено билетов: " + IspTik.ToString() + " шт.");
                    
                    if (info.ShowDialog() == DialogResult.OK)
                    {
                        (FSender.TopLevelControl as Form).Close();
                    }

                }

            }

        }
    }
}





