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



    public class clTransferReportTickets
    {
        private Excel.Application ExcelAPP;
        private Excel.Sheets ExcelSheets;
        private Excel.Worksheet ExcelWorkSheet;
        private Excel.Workbooks ExcelAPpWorkBooks;
        private Excel.Workbook ExcelAPpWorkBook;
        private Excel.Range ExcelCells;

        public string Id_Empl_Kto { get; set; }
        public string Id_Empl_Komu { get; set;}
        public DataGridView Data { get; set; }
        public string path = "";

        string EtalonReportTransfer = clDataFile.GetPathTransferFile();

        public clTransferReportTickets()
        {
            // Запускаем приложение
            ExcelAPP = new Excel.Application();
            // Открываем файл
            ExcelAPP.Workbooks.Open(EtalonReportTransfer);
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



        public void GetReportTransferTickets()
        {
            try
            {
                clEmployees emplkto = new clEmployees(this.Id_Empl_Kto);
                clEmployees emplKomy = new clEmployees(this.Id_Empl_Komu);
                
                string FioKto = emplkto.GetSmallFIO();
                string FioKomy = emplKomy.GetSmallFIO();
                ExcelCells = ExcelWorkSheet.get_Range("A1", Type.Missing);
                ExcelCells.Value2 = "ТРЕБОВАНИЕ-НАКЛАДНАЯ № "+clFix.GetTransferFIX().ToString();
                ExcelCells = ExcelWorkSheet.get_Range("C5", Type.Missing);
                ExcelCells.Value2 = emplkto.Otdel;
                ExcelCells = ExcelWorkSheet.get_Range("C6", Type.Missing);
                ExcelCells.Value2 = emplKomy.Otdel;
                ExcelCells = ExcelWorkSheet.get_Range("A20", Type.Missing);
                ExcelCells.Value2 = emplkto.Dolzhost;
                ExcelCells = ExcelWorkSheet.get_Range("C20", Type.Missing);
                ExcelCells.Value2 = emplkto.GetSmallFIO();
                ExcelCells = ExcelWorkSheet.get_Range("B25", Type.Missing);
                ExcelCells.Value2 = emplKomy.Dolzhost;
                ExcelCells = ExcelWorkSheet.get_Range("F25", Type.Missing);
                ExcelCells.Value2 = emplKomy.GetSmallFIO();

                string row = "";
                Double Summa = 0;

                for (int i = 0; i <= Data.RowCount - 1; i++)
                {

                    row = (16 + i).ToString();

                    string Name = "Социальные льготный проездной билет (серия " + Data.Rows[i].Cells[2].Value.ToString() + ")";
                    string Range = Data.Rows[i].Cells[3].Value.ToString() + " - " + Data.Rows[i].Cells[4].Value.ToString();
                    int RangeCount = Convert.ToInt32(Data.Rows[i].Cells[4].Value.ToString()) - Convert.ToInt32(Data.Rows[i].Cells[3].Value.ToString()) + 1;
                    Double Price = 1;


                    ExcelCells = ExcelWorkSheet.get_Range("A" + row, Type.Missing);
                    ExcelCells.Value2 = (i + 1).ToString();
                    ExcelCells = ExcelWorkSheet.get_Range("B" + row, Type.Missing);
                    ExcelCells.Value2 = Name;
                    ExcelCells = ExcelWorkSheet.get_Range("C" + row, Type.Missing);
                    ExcelCells.Value2 = Range;
                    ExcelCells = ExcelWorkSheet.get_Range("D" + row, Type.Missing);
                    ExcelCells.NumberFormat = "00000000";
                    ExcelCells.Value2 = "4";
                    ExcelCells = ExcelWorkSheet.get_Range("E" + row, Type.Missing);
                    ExcelCells.Value2 = "шт.";
                    ExcelCells = ExcelWorkSheet.get_Range("F" + row, Type.Missing);
                    ExcelCells.Value2 = "796";
                    ExcelCells = ExcelWorkSheet.get_Range("G" + row, Type.Missing);
                    ExcelCells.Value2 = Price.ToString("F2");
                    ExcelCells = ExcelWorkSheet.get_Range("H" + row, Type.Missing);
                    ExcelCells.Value2 = RangeCount.ToString("F2");
                    ExcelCells = ExcelWorkSheet.get_Range("I" + row, Type.Missing);
                    ExcelCells.Value2 = RangeCount.ToString("F2");
                    ExcelCells = ExcelWorkSheet.get_Range("J" + row, Type.Missing);
                    Summa = Summa + (RangeCount * Price);
                    ExcelCells.Value2 = (RangeCount * Price).ToString("F2");
                    ExcelCells = ExcelWorkSheet.get_Range("K" + row, Type.Missing);
                    ExcelCells.Value2 = "4.03.1";
                    ExcelCells = ExcelWorkSheet.get_Range("L" + row, Type.Missing);
                    ExcelCells.Value2 = "4.03.1";
                    ExcelCells = ExcelWorkSheet.get_Range("M" + row, Type.Missing);
                    ExcelCells.Value2 = "";

                    ExcelCells = ExcelWorkSheet.get_Range("A" + row, "M" + row);
                    ExcelCells.HorizontalAlignment = Excel.Constants.xlCenter;
                    ExcelCells.VerticalAlignment = Excel.Constants.xlCenter;
                    //Устанавливаем стиль и толщину линии
                    ExcelCells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    ExcelCells.Borders.Weight = Excel.XlBorderWeight.xlThin;



                    //Добавляем новую строку
                    ExcelCells = ExcelWorkSheet.get_Range("A" + (Convert.ToInt32(row) + 1).ToString(), "M" + (Convert.ToInt32(row) + 1).ToString());          // Устанавливаем ссылку ячеек на ячейку A1
                    ExcelCells.Insert(Type.Missing);
                }
                ExcelCells = ExcelWorkSheet.get_Range("A" + (Convert.ToInt32(row) + 1).ToString(), "M" + (Convert.ToInt32(row) + 1).ToString());          // Устанавливаем ссылку ячеек на ячейку A1
                ExcelCells.Insert(Type.Missing);

                ExcelCells = ExcelWorkSheet.get_Range("F" + (Convert.ToInt32(row) + 1).ToString(), Type.Missing);
                ExcelCells.Value2 = "Итого:";
                ExcelCells = ExcelWorkSheet.get_Range("G" + (Convert.ToInt32(row) + 1).ToString(), Type.Missing);
                ExcelCells.Value2 = "X";
                ExcelCells = ExcelWorkSheet.get_Range("H" + (Convert.ToInt32(row) + 1).ToString(), Type.Missing);
                ExcelCells.Value2 = "X";
                ExcelCells = ExcelWorkSheet.get_Range("I" + (Convert.ToInt32(row) + 1).ToString(), Type.Missing);
                ExcelCells.Value2 = "X";
                ExcelCells = ExcelWorkSheet.get_Range("J" + (Convert.ToInt32(row) + 1).ToString(), Type.Missing);
                ExcelCells.Value2 = Summa.ToString("F2");

                ExcelCells = ExcelWorkSheet.get_Range("F" + (Convert.ToInt32(row) + 1).ToString(), "J" + (Convert.ToInt32(row) + 1).ToString());
                ExcelCells.HorizontalAlignment = Excel.Constants.xlCenter;
                ExcelCells.VerticalAlignment = Excel.Constants.xlCenter;
                //Устанавливаем стиль и толщину линии
                ExcelCells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                ExcelCells.Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Сохраняем файл в темпе
                Random rnd = new Random();
                path = CLUtils.GetPathTemp() + "\\" + rnd.Next()+ ".xls";
                ExcelAPpWorkBook.SaveAs(@path);
                ExcelAPpWorkBook.Saved = true;
                
            }
            finally
            { ExcelAPP.Quit();
              File.Delete(EtalonReportTransfer);
            }
            // Закрываем приложение и отсоединяемся от него
            try
            {
                Process.Start(@path);
            }
            catch (Exception error ) { MessageBox.Show("Ошибка при запуске, Отчета! " + error.ToString()); }
            // Запускаем файл
            
        }

    }
}
