using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }


        public static Dictionary<int, string> GetDictionaryApplication()
        {
            Dictionary<int, string> App = new Dictionary<int, string>();

            App.Add(1, "АРМ Оператора");
            App.Add(2, "АРМ Бухгалтера");
            App.Add(3, "АРМ Администратор");

            return App;
        }
    }



}
