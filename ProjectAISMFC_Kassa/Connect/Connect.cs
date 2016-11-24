using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Diagnostics;

namespace ConnectLib
{
    public class SettingConnect
    {
        public string ip { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public  bool ValidSetting()
        {
                try
                {
                    System.Net.NetworkInformation.Ping ping =
                    new System.Net.NetworkInformation.Ping();
                    System.Net.NetworkInformation.PingReply pingReply = ping.Send(ip);

                    if (pingReply.Status.ToString() != "TimedOut")
                    {
                        Connect.GetDateServer();
                        return true;
                    }
                    else return false;
                }
                catch
                {
                    
                    return false;
                }
        }



        public bool ExistsFileSetting()
        {
            string path = @"SettingFileConnect.xml";


            if (File.Exists(path))
            {
                XDocument xdoc = XDocument.Load(path);
                foreach (XElement Setting in xdoc.Element("ROOT").Elements("Connection"))
                {
                    XElement IP = Setting.Element("IP");
                    XElement Login = Setting.Element("Login");
                    XElement Password = Setting.Element("Password");

                    this.ip = IP.Value.ToString().Trim();
                    this.login = Login.Value.ToString().Trim();
                    this.password = Password.Value.ToString().Trim();
                    ConnectLib.Properties.Settings.Default.ipServer = this.ip;
                    ConnectLib.Properties.Settings.Default.Password = this.password;
                    ConnectLib.Properties.Settings.Default.Login = this.login;
                }

                return true;
            }
            else
            {
                MessageBox.Show("Файл настроек не найден, создаем новый, необходимо заполнить данными. Открываем файл.");
                
                XDocument xdoc = new XDocument();
                // создаем первый элемент
                XElement Setting = new XElement("Connection");
                // создаем атрибут
                XElement IP = new XElement("IP", "127.0.0.1");
                XElement Login = new XElement("Login", "admin");
                XElement Password = new XElement("Password", "admin");
                // добавляем атрибут и элементы в первый элемент
                Setting.Add(IP);
                Setting.Add(Login);
                Setting.Add(Password);

                // создаем корневой элемент
                XElement root = new XElement("ROOT");
                // добавляем в корневой элемент
                root.Add(Setting);
                
                // добавляем корневой элемент в документ
                xdoc.Add(root);
                //сохраняем документ
                xdoc.Save(path);

                Process.Start(path);

                return false;
            }

        }


     }

    static public class Connect
    {





        public static string GetConn()
        {
            try
            {
                string IpBD = ConnectLib.Properties.Settings.Default.ipServer.ToString(); 
                string Password = ConnectLib.Properties.Settings.Default.Password.ToString(); ;
                string User = ConnectLib.Properties.Settings.Default.Login.ToString(); ;

                return "Password =" + Password + " ; Persist Security Info = True; User ID =" + User
                    + " ; Initial Catalog = KassaBilet; Data Source =" + IpBD;

            }
            catch
            {
                MessageBox.Show("В конфигурационном файле, обнаружена ошибка!!!!");
                return "";
                
            }          
            //return ConnectString;
        }

        

        static public DateTime GetDateServer() // возвращает дату и время от сервера
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connect.GetConn();
            SqlCommand Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GETDatetime]";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ret";
            param.SqlDbType = SqlDbType.DateTime;
            param.Direction = ParameterDirection.Output;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            return Convert.ToDateTime(Command.Parameters["@ret"].Value.ToString());
        }







    }
}
