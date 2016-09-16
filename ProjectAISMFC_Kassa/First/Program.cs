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
            
            

            if (Directory.Exists(@dir) != true) Directory.CreateDirectory(dir);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ARMBuh2v("2BA2A578-A7B0-47C4-98EC-0DFFCD52734F"));
            



            //FormControlUser Aut = new FormControlUser();
            //if (Aut.ShowDialog() == DialogResult.OK)
            //{
            //    if (Aut.Tag.ToString() == "-1") MessageBox.Show("Сотруднику, не назначена роль!!! Обратитесь к Администратору.");
            //    if (Aut.Tag.ToString() == "0") Application.Run(new OperARM(Aut.comboBox1.SelectedValue.ToString(), 1));
            //    if (Aut.Tag.ToString() == "1") Application.Run(new ARMBuh2v());
            //    if (Aut.Tag.ToString() == "3") MessageBox.Show("Форма в разработке");

            //    clLog log = new clLog();
            //    log.InsertLog(Aut.comboBox1.SelectedValue.ToString(), 100);

            //}




            try
            {
                Directory.Delete(dir, true); //true - если директория не пуста (удалит и файлы и папки)
            }
            catch
            {
                MessageBox.Show("Не все открытые файлы были закрыты");
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
