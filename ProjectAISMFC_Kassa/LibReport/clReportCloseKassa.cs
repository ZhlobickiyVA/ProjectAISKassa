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
            public Double OstatikInKassa;
            public int KolVoReesstr;
            public string IdEmpl;
            public string idEmplKomy;
            public string FioGlBuh;
            public Decimal SolDoBegin;
            public DataTable DateItogClose;
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
                ExcelCells.Value2 = this.Parametr.SolDoBegin.ToString("C2");
                // Кто принимает деньги
                clEmployees Em = new clEmployees(this.Parametr.idEmplKomy);
                ExcelCells = ExcelWorkSheet.get_Range("H25", Type.Missing);
                ExcelCells.Value2 = Em.GetSmallFIO();
                ExcelCells = ExcelWorkSheet.get_Range("B26", Type.Missing);
                ExcelCells.Value2 = Em.GetPasportString();
                // Главный бухгалтер
                ExcelCells = ExcelWorkSheet.get_Range("H33", Type.Missing);
                ExcelCells.Value2 = clORG.GetGlBuh();
                // Кто сдал Деньги
                ExcelCells = ExcelWorkSheet.get_Range("H29", Type.Missing);
                ExcelCells.Value2 = clEmployees.GetSmallFIO(this.Parametr.IdEmpl);

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
                    ExcelCells.Value2 = this.Parametr.DateItogClose.Rows[i].ItemArray[1].ToString();
                    ExcelCells = ExcelWorkSheet.get_Range("B" + row, Type.Missing);
                    ExcelCells.Value2 = this.Parametr.DateItogClose.Rows[i].ItemArray[2].ToString();
                    ExcelCells = ExcelWorkSheet.get_Range("C" + row, Type.Missing);
                    ExcelCells.Value2 = this.Parametr.DateItogClose.Rows[i].ItemArray[3].ToString();

                }


                //clEmployees emplkto = new clEmployees(this.Id_EmpMot);
                //string FioMot = emplkto.GetSmallFIO();
                //// Руководитель учереждения
                //ExcelCells = ExcelWorkSheet.get_Range("F2", Type.Missing);
                //ExcelCells.Value2 = org.Director.Trim();
                //// Номер Акта
                //ExcelCells = ExcelWorkSheet.get_Range("A5", Type.Missing);
                //ExcelCells.Value2 = "АКТ № " + clFix.GetCanceledFIX().ToString();
                //// Комиссия в составе
                //ExcelCells = ExcelWorkSheet.get_Range("B16", Type.Missing);
                //ExcelCells.Value2 = org.GetCommisia().ToString();
                //// НПА по комиммии
                //ExcelCells = ExcelWorkSheet.get_Range("A18", Type.Missing);
                //ExcelCells.Value2 = org.GetNPACommisia(BeginRange, EndRange).ToString();
                //// МОЛ
                //ExcelCells = ExcelWorkSheet.get_Range("B12", Type.Missing);
                //ExcelCells.Value2 = FioMot;
                //// Председатель коммисии
                //ExcelCells = ExcelWorkSheet.get_Range("D24", Type.Missing);
                //ExcelCells.Value2 = org.PredComDolzh;
                //ExcelCells = ExcelWorkSheet.get_Range("F24", Type.Missing);
                //ExcelCells.Value2 = org.PredComFio;
                //// 1 член комисии
                //ExcelCells = ExcelWorkSheet.get_Range("D27", Type.Missing);
                //ExcelCells.Value2 = org.cl1ComDolzh;
                //ExcelCells = ExcelWorkSheet.get_Range("F27", Type.Missing);
                //ExcelCells.Value2 = org.cl1ComFIo;
                //// 2 член комисии
                //ExcelCells = ExcelWorkSheet.get_Range("30", Type.Missing);
                //ExcelCells.Value2 = org.cl2ComDolzh;
                //ExcelCells = ExcelWorkSheet.get_Range("30", Type.Missing);
                //ExcelCells.Value2 = org.cl2ComFIo;
                //// 3 член комисии
                //ExcelCells = ExcelWorkSheet.get_Range("33", Type.Missing);
                //ExcelCells.Value2 = org.cl3ComDolzh;
                //ExcelCells = ExcelWorkSheet.get_Range("33", Type.Missing);
                //ExcelCells.Value2 = org.cl3ComFIo;
                //string row = "";
                //for (int i = 0; i <= Data.RowCount - 1; i++)
                //{

                //    row = (23 + i).ToString();

                //    string Name = "Социальные льготный проездной билет";
                //    string Range = Data.Rows[i].Cells[3].Value.ToString() + " - " + Data.Rows[i].Cells[4].Value.ToString();
                //    int RangeCount = Convert.ToInt32(Data.Rows[i].Cells[4].Value.ToString()) - Convert.ToInt32(Data.Rows[i].Cells[3].Value.ToString()) + 1;
                //    // Наименование
                //    ExcelCells = ExcelWorkSheet.get_Range("A" + row, Type.Missing);
                //    ExcelCells.Value2 = Name;
                //    // номер
                //    ExcelCells = ExcelWorkSheet.get_Range("B" + row, Type.Missing);
                //    ExcelCells.Value2 = Range;
                //    // Серия
                //    ExcelCells = ExcelWorkSheet.get_Range("C" + row, Type.Missing);
                //    ExcelCells.Value2 = "ФС";
                //    // Причина списания
                //    ExcelCells = ExcelWorkSheet.get_Range("D" + row, Type.Missing);
                //    ExcelCells.Value2 = "Испорчен";
                //    // Количество
                //    ExcelCells = ExcelWorkSheet.get_Range("E" + row, Type.Missing);
                //    ExcelCells.Value2 = RangeCount;
                //    // Дата уничтожения
                //    ExcelCells = ExcelWorkSheet.get_Range("F" + row, Type.Missing);
                //    ExcelCells.Value2 = System.DateTime.Now.Date.ToShortDateString();
                //    // ----------------------------------------------------------------
                //    ExcelCells = ExcelWorkSheet.get_Range("A" + row, "F" + row);
                //    ExcelCells.HorizontalAlignment = Excel.Constants.xlCenter;
                //    ExcelCells.VerticalAlignment = Excel.Constants.xlCenter;
                //    //Устанавливаем стиль и толщину линии
                //    ExcelCells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //    ExcelCells.Borders.Weight = Excel.XlBorderWeight.xlThin;
                //    //Добавляем новую строку
                //    ExcelCells = ExcelWorkSheet.get_Range("A" + (Convert.ToInt32(row) + 1).ToString(), "F" + (Convert.ToInt32(row) + 1).ToString());          // Устанавливаем ссылку ячеек на ячейку A1
                //    ExcelCells.Insert(Type.Missing);
                //}

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
