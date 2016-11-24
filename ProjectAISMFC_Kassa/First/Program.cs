using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using LibEventLog;
using LibARM_Operator;
using LibARM_Buhgalter;
using LibSecurity;
using UtilDLL;
using LibEmployees;
using ConnectLib;


namespace GeneralMidule
{
    static class Program
    {

        public static string dir = "@"+ CLUtils.GetTempDic.ToString();


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SettingConnect Connect = new SettingConnect();


            if (Connect.ExistsFileSetting())
            {
                
                if (!Connect.ValidSetting())
                {
                    MessageBox.Show("Не удалось подключиться к серверу!, программа будет закрыта!");
                    Application.Exit();
                }
                else
                {
                    if (Directory.Exists(@dir) != true) Directory.CreateDirectory(dir);

                    //Application.Run(new ARMBuh2v("2BA2A578-A7B0-47C4-98EC-0DFFCD52734F"));
                    //Application.Run(new Form1());

                    string idEmpl = "";
                    if (clAut.RunAuto(out idEmpl))
                    {
                        clEmployees empl = new clEmployees(idEmpl);
                        int level = clRole.GetLevel(empl.idRole);


                        switch (level)
                        {
                            case 0: Application.Run(new ARMOperatorV2(idEmpl)); break;
                            case 1: Application.Run(new ARMBuh2v(idEmpl)); break;
                            case 2: Application.Run(new Form1()); break;
                            default: MessageBox.Show("Ошибка инициализации!"); break;
                        }
                    }

                }
                try
                {
                    Directory.Delete(dir, true); //true - если директория не пуста (удалит и файлы и папки)
                }
                catch
                {
                    MessageBox.Show("Не все открытые файлы были закрыты");
                }
            }


        }

        public static Dictionary<int, string> GetDictionaryApplication()
        {
            Dictionary<int, string> App = new Dictionary<int, string>();

            App.Add(1,"АРМ Оператора");
            App.Add(2, "АРМ Бухгалтера");
            App.Add(3, "АРМ Администратор");

            return App;
        }


    }
}
