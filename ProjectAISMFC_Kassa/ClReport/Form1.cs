using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;


namespace ClReport
{
    public partial class Form1 : Form
    {
        private Excel.Application ExcelAPP;
        private Excel.Window ExcelWindow;

        private Excel.Sheets ExcelSheets;
        private Excel.Worksheet ExcelWorkSheet;

        private Excel.Workbooks ExcelAPpWorkBooks;
        private Excel.Workbook ExcelAPpWorkBook;

        private Excel.Range ExcelCells;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Запускаем приложение
            ExcelAPP = new Excel.Application();
            //ExcelAPP.DefaultSaveFormat = Excel.XlFileFormat.xl
            
            // Открываем файл
            ExcelAPP.Workbooks.Open(Path.GetDirectoryName(Application.ExecutablePath)+ @"\TransferReport.xls");
            // Получаем ссылки на книги в файле
            ExcelAPpWorkBooks = ExcelAPP.Workbooks;
            // Получаем ссылку на первую книгу
            ExcelAPpWorkBook = ExcelAPpWorkBooks[1];
            // Получили список листов
            ExcelSheets = ExcelAPpWorkBook.Worksheets;
            // Получили ссылку на первый лист
            ExcelWorkSheet = (Excel.Worksheet)ExcelSheets.get_Item(1);
            // Выделение группы ячеек
            ExcelCells = ExcelWorkSheet.get_Range("A16", Type.Missing);
            ExcelCells.Value2 = "1";
            ExcelCells = ExcelWorkSheet.get_Range("B16", Type.Missing);
            ExcelCells.Value2 = "Социальные льготный проездной билет (серия ШС)";
            ExcelCells = ExcelWorkSheet.get_Range("C16", Type.Missing);
            ExcelCells.Value2 = "0000001-0001000";
            ExcelCells = ExcelWorkSheet.get_Range("D16", Type.Missing);
            ExcelCells.Value2 = "00000000004";
            ExcelCells = ExcelWorkSheet.get_Range("E16", Type.Missing);
            ExcelCells.Value2 = "шт.";
            ExcelCells = ExcelWorkSheet.get_Range("F16", Type.Missing);
            ExcelCells.Value2 = "796";
            ExcelCells = ExcelWorkSheet.get_Range("G16", Type.Missing);
            ExcelCells.Value2 = "1.00";
            ExcelCells = ExcelWorkSheet.get_Range("H16", Type.Missing);
            ExcelCells.Value2 = "500,000";
            ExcelCells = ExcelWorkSheet.get_Range("I16", Type.Missing);
            ExcelCells.Value2 = "500,000";
            ExcelCells = ExcelWorkSheet.get_Range("J16", Type.Missing);
            ExcelCells.Value2 = "500,000";
            ExcelCells = ExcelWorkSheet.get_Range("K16", Type.Missing);
            ExcelCells.Value2 = "4.03.1";
            ExcelCells = ExcelWorkSheet.get_Range("L16", Type.Missing);
            ExcelCells.Value2 = "4.03.1";
            ExcelCells = ExcelWorkSheet.get_Range("M16", Type.Missing);
            ExcelCells.Value2 = "";
            ExcelCells = ExcelWorkSheet.get_Range("A16","M16");
            ExcelCells.HorizontalAlignment = Excel.Constants.xlCenter;
            ExcelCells.VerticalAlignment = Excel.Constants.xlCenter;
            //Устанавливаем стиль и толщину линии
            ExcelCells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            ExcelCells.Borders.Weight = Excel.XlBorderWeight.xlThin;


            


            ExcelCells = ExcelWorkSheet.get_Range("A17", "M17");          // Устанавливаем ссылку ячеек на ячейку A1
            ExcelCells.Insert(Type.Missing);




            // Отображаем приложение
            ExcelAPpWorkBook.SaveAs("D:\\1.xls");
            ExcelAPpWorkBook.Saved = true;
            ExcelAPP.Quit();
            MessageBox.Show("Все ок!");
            Process.Start("D:\\1.xls");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
