using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using LibEmployees;
using UtilDLL;
using LibDataFile;




namespace LibReport
{
    public class clReportCloseKassa
    {
        public struct ParCloseKassa
        {
            public Decimal OstatikInKassa;
            public int KolVoReesstr;
            public string IdEmpl;
            public string idEmplKomy;
            public string FioGlBuh;
            public Decimal SolDoBegin;
            public DataTable DateItogClose;
            public decimal SumInKassa;
            public decimal SummaTransfer;
        }

        public ParCloseKassa Parametr;

        private Excel.Application ExcelAPP;
        private Excel.Sheets ExcelSheets;
        private Excel.Worksheet ExcelWorkSheet;
        private Excel.Workbooks ExcelAPpWorkBooks;
        private Excel.Workbook ExcelAPpWorkBook;
        private Excel.Range ExcelCells;
        clORG org = new clORG();

        //public DataGridView Data { get; set; }
        public string path = "";

        string EtalonCloseKassa = clDataFile.GetPathCloseKassaFile();

        public clReportCloseKassa()
        {
            try
            {
                // Запускаем приложение
                ExcelAPP = new Excel.Application();
                // Открываем файл
                ExcelAPP.Workbooks.Open(EtalonCloseKassa);
                // Получаем ссылки на книги в файле
                ExcelAPpWorkBooks = ExcelAPP.Workbooks;
                // Получаем ссылку на первую книгу
                ExcelAPpWorkBook = ExcelAPpWorkBooks[1];
                // Получили список листов
                ExcelSheets = ExcelAPpWorkBook.Worksheets;
                // Получили ссылку на первый лист
                ExcelWorkSheet = (Excel.Worksheet)ExcelSheets.get_Item(1);
                // Выделение группы ячеек
            }
            catch
            {
                ExcelAPP.Quit();
                File.Delete(EtalonCloseKassa);
                MessageBox.Show("Ошибка инициализации!!! Файла!");
            }
        }



        public void GetReportCloseKassa()
        {
            try
            {
                // Название организации
                ExcelCells = ExcelWorkSheet.get_Range("A5", Type.Missing);
                ExcelCells.Value2 = org.slName.ToString();
                // Полное Имя сотрудника формирующий отчет
                ExcelCells = ExcelWorkSheet.get_Range("A7", Type.Missing);
                ExcelCells.Value2 = clEmployees.GetBigFIO(this.Parametr.IdEmpl);
                // Номер документа
                ExcelCells = ExcelWorkSheet.get_Range("E10", Type.Missing);
                ExcelCells.Value2 = clFix.GetCloseKasFIX();
                // Сальдо на начало дня
                ExcelCells = ExcelWorkSheet.get_Range("E12", Type.Missing);
                ExcelCells.Value2 = this.Parametr.SolDoBegin.ToString("F2");
                // Кто принимает деньги
                clEmployees Em = new clEmployees(this.Parametr.idEmplKomy);
                ExcelCells = ExcelWorkSheet.get_Range("H24", Type.Missing);
                ExcelCells.Value2 = Em.GetSmallFIO();
                ExcelCells = ExcelWorkSheet.get_Range("B25", Type.Missing);
                ExcelCells.Value2 = Em.GetPasportString();
                // Главный бухгалтер
                ExcelCells = ExcelWorkSheet.get_Range("H32", Type.Missing);
                ExcelCells.Value2 = clORG.GetGlBuh();
                // Кто сдал Деньги
                ExcelCells = ExcelWorkSheet.get_Range("H28", Type.Missing);
                ExcelCells.Value2 = clEmployees.GetSmallFIO(this.Parametr.IdEmpl);

                
                                               
                ExcelCells = ExcelWorkSheet.get_Range("C21", Type.Missing);
                ExcelCells.Value2 = RuDateAndMoneyConverter.CurrencyToTxtNoRubNoKop((double)this.Parametr.SummaTransfer,true) + "  -----------------";
                ExcelCells = ExcelWorkSheet.get_Range("H23", Type.Missing);

                string kop = RuDateAndMoneyConverter.CurrencyToTxtKop((double)this.Parametr.SummaTransfer, true);
                if (kop == "00") ExcelCells.Value2 = "-----";
                else ExcelCells.Value2 = kop;

                ExcelCells = ExcelWorkSheet.get_Range("A23", Type.Missing);
                ExcelCells.Value2 = "--------------------------------------------------------------";

                ExcelCells = ExcelWorkSheet.get_Range("E16", Type.Missing);
                ExcelCells.Value2 = this.Parametr.OstatikInKassa.ToString("F2");

                for (int i = 0; i <= this.Parametr.DateItogClose.Rows.Count - 1; i++)
                {
                    string row = (i + 15).ToString();
                    //Добавляем новую строку
                    ExcelCells = ExcelWorkSheet.get_Range("A" + (Convert.ToInt32(row)).ToString(), "I" + (Convert.ToInt32(row)).ToString());          // Устанавливаем ссылку ячеек на ячейку A1
                    ExcelCells.Insert(Type.Missing);

                }

                for (int i = 0; i <= this.Parametr.DateItogClose.Rows.Count - 1; i++)
                {
                    string row = (i + 15).ToString();
                    ExcelCells = ExcelWorkSheet.get_Range("A" + row, Type.Missing);
                    ExcelCells.Value2 = this.Parametr.DateItogClose.Rows[i].ItemArray[0].ToString();
                    ExcelCells = ExcelWorkSheet.get_Range("D" + row, Type.Missing);
                    if (i == 0) ExcelCells.Value2 = this.Parametr.KolVoReesstr.ToString();
                    else ExcelCells.Value2 = 0;
                    ExcelCells = ExcelWorkSheet.get_Range("B" + row, Type.Missing);
                    ExcelCells.NumberFormat = "#,##0.00";
                    ExcelCells.Value2 = this.Parametr.DateItogClose.Rows[i].ItemArray[1].ToString();
                    ExcelCells = ExcelWorkSheet.get_Range("C" + row, Type.Missing);
                    ExcelCells.NumberFormat = "#,##0.00";
                    ExcelCells.Value2 = this.Parametr.DateItogClose.Rows[i].ItemArray[2].ToString();

                    ExcelCells = ExcelWorkSheet.get_Range("A" + (Convert.ToInt32(row)).ToString(), "I" + (Convert.ToInt32(row)).ToString()); 
                    ExcelCells.HorizontalAlignment = Excel.Constants.xlCenter;
                    ExcelCells.VerticalAlignment = Excel.Constants.xlCenter;
                    ExcelCells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    ExcelCells.Borders.Weight = Excel.XlBorderWeight.xlThin;
                }

                ExcelCells = ExcelWorkSheet.get_Range("E15", "I" + (15+(this.Parametr.DateItogClose.Rows.Count - 1)).ToString());
                ExcelCells.Merge(Type.Missing);
                ExcelCells.HorizontalAlignment = Excel.Constants.xlCenter;
                ExcelCells.VerticalAlignment = Excel.Constants.xlCenter;
                ExcelCells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                ExcelCells.Borders.Weight = Excel.XlBorderWeight.xlThin;

                ExcelCells = ExcelWorkSheet.get_Range("E15", Type.Missing);
                ExcelCells.NumberFormat = "#,##0.00";
                ExcelCells.Value2 = this.Parametr.SummaTransfer.ToString("F2");
                ExcelCells.Font.Size = 14;
                

                ExcelCells = ExcelWorkSheet.get_Range("E" + (15 + (this.Parametr.DateItogClose.Rows.Count)).ToString(), Type.Missing);
                ExcelCells.RowHeight = 15;
                ExcelCells = ExcelWorkSheet.get_Range("E" + (16 + (this.Parametr.DateItogClose.Rows.Count)).ToString(), Type.Missing);
                ExcelCells.RowHeight = 23;

                //// Сохраняем файл в темпе
                Random rnd = new Random();
                path = CLUtils.GetPathTemp() + "\\" + rnd.Next() + ".xls";
                ExcelAPpWorkBook.SaveAs(@path);
                ExcelAPpWorkBook.Saved = true;

            }
            finally
            {
                ExcelAPP.Quit();
                File.Delete(EtalonCloseKassa);
            }
            // Закрываем приложение и отсоединяемся от него
            try
            {
                Process.Start(@path);
            }
            catch (Exception error) { MessageBox.Show("Ошибка при запуске, Отчета! " + error.ToString()); }
            // Запускаем файл

        }


    }
}
