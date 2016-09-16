using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using ConnectLib;
using Dosadi.EZTwain;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Reflection;
using UtilDLL;
using LibDataFile;

namespace LibDataFile
{
    public class clDataFile
    {

        public string id { get; set; }
        public string NameFile { get; set; }
        public string TypeFile { get; set; }
        public byte[] ImageData { get; set; }
        public string IdClient { get; set; }

        private  SqlConnection connection = new SqlConnection(Connect.GetConn());
        private SqlCommand Command = new SqlCommand();
        public static string ServiceIdClient = "A0000000-D000-0000-0000-000000000000";

        public clDataFile() { } //пустой конструкто
        public clDataFile(string id)
        {
            this.id = id;
            Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataFileToID]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                this.id = reader["id"].ToString();
                this.NameFile = reader["NameFile"].ToString();
                this.TypeFile = reader["TypeFile"].ToString();
                this.IdClient = reader["id_Cli"].ToString();
                this.ImageData = (byte[])reader.GetValue(4);
            }
            else MessageBox.Show("Пустой запрос! Сотрудник не найден.");
            connection.Close();


        }

        public static DataTable GetListDataFile(string id)
        {
            SqlConnection connection = new SqlConnection(Connect.GetConn());
            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[GetDataFile]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(id);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = Command;
            DataSet ds = new DataSet();
            data.Fill(ds);
            connection.Close();
            return ds.Tables[0];
 
        }
        public static void AddFile(string idClient)
        {
            OpenFileDialog fi = new OpenFileDialog();
            fi.Title = "Выберите файл.";
            fi.Multiselect = false;
            if (fi.ShowDialog() == DialogResult.OK)
            {
                clDataFile dat = new clDataFile();
                dat = clDataFile.GetArrayByteToFile(fi.FileName);
                dat.IdClient = idClient;
                dat.Operation_Save_DataFile();
            }
        }

        public static void AddFileToScan(string idClient,string NameFile = "")
        {
            clDataFile dat = new clDataFile();
            dat.IdClient = idClient;

            string value = NameFile;
            if (value == "")
            {
                if (CLUtils.InputBox("Название файла", "Введите название файла", ref value) == DialogResult.OK)
                { 
                    dat.ImageData = clDataFile.GetImageFromScan();
                    dat.NameFile = value;
                    dat.TypeFile = ".jpg";
                    dat.Operation_Save_DataFile();
                }
            }
            else
            {
                dat.ImageData = clDataFile.GetImageFromScan();
                dat.NameFile = value;
                dat.TypeFile = ".jpg";
                dat.Operation_Save_DataFile();
            }
        }

        public static void DeleteFile(string id)
        {
            clDataFile dat = new clDataFile(id);
            dat.Operatin_Delete_FileData();
        }

        public static byte[] GetImageFromScan()
        {
            Image srcImage;

            IntPtr hdib = IntPtr.Zero;
            try
            {
                if (LibDataFile.Properties.Settings.Default.SourceScanDefault != 1)
                EZTwain.SelectImageSource(new IntPtr());
                else EZTwain.OpenDefaultSource(); //Открываем twain источник по-умолчанию, если это не наш сканер — косяк, придется дорабатывать программу и добавлять возможность выбора устройства. Такая функция есть в EZTwain, просто нужно будет ее добавить. 
                //EZTwain.SetBitDepth(4); //установка глубины цвета 24бит/пиксел 
                //EZTwain.SetCurrentResolution(150); //разрешение при сканировании 150 dpi
                EZTwain.SetHideUI(0); //не показывать диалог сканера, сразу сканировать
                hdib = EZTwain.AcquireNative(new IntPtr(), 2); //запуск сканирования
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return null; }
            if (hdib == IntPtr.Zero) { MessageBox.Show("Изображение не загружено."); return null; }
            srcImage = new Bitmap(bitmapFromDIB(hdib)); //делаем bitmap из DIB и записываем в переменную. Теперь картинка хранится в srcImage, можно работать дальше.

            ImageConverter convert = new ImageConverter();
            return (byte[])convert.ConvertTo(srcImage, typeof(byte[]));

        }
        public static clDataFile GetArrayByteToFile(string path)
        {
            clDataFile dat = new clDataFile();
            dat.NameFile = Path.GetFileNameWithoutExtension(path);
            dat.TypeFile = Path.GetExtension(path);
            using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.Open))
            {
                dat.ImageData = new byte[fs.Length];
                fs.Read(dat.ImageData, 0, dat.ImageData.Length);
            }
            return dat;
        }
        public string GetFileToArrayByte()
        {
            try
            {
                string file = CLUtils.GetPathTemp()+"\\" + this.NameFile + this.TypeFile.ToString();
                //создали файл на диске C:\
                FileStream fs = new FileStream(@file, FileMode.Create);
                //Создали объект BinaryWriter для записи в файл
                BinaryWriter bw = new BinaryWriter(fs);
                //получили текущую запись
                byte[] mas = (byte[])this.ImageData;
                //записали данные
                bw.Write(mas, 0, mas.Length);
                //закрыли потоки
                bw.Close();
                fs.Close();
                return file;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return null;
            }
        }
        void Operation_Save_DataFile()
        {
            try
            {
                Command = connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "[InsertFileData]";
                Command.Parameters.Add("@id_Cli", SqlDbType.NVarChar, 100);
                Command.Parameters["@id_Cli"].Value = this.IdClient;
                Command.Parameters.Add("@NameFile", SqlDbType.NVarChar, 100);
                Command.Parameters["@NameFile"].Value = this.NameFile.Trim();
                Command.Parameters.Add("@TypeFile", SqlDbType.NVarChar, 100);
                Command.Parameters["@TypeFile"].Value = this.TypeFile.Trim();
                Command.Parameters.Add("@File", SqlDbType.VarBinary, this.ImageData.Length);
                Command.Parameters["@File"].Value = this.ImageData;
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception erroe) { MessageBox.Show("Ошибка транзакции!"); }
        }
        void Operatin_Delete_FileData()
        {
            Command = connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "[DeleteFileToBase]";
            Command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            Command.Parameters["@id"].Value = new Guid(this.id);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }
// -------------------------------------------------------------------------------------------------------------------------------------
        public static void RunListFileReport()
        {
            FormFileReport f = new FormFileReport();
            f.Show();
        }


        public static string GetPathTransferFile()
        {
            DataTable table = new DataTable();
            table = clDataFile.GetListDataFile(clDataFile.ServiceIdClient);
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                if (LibDataFile.Properties.Settings.Default.TransferReport.ToString() == table.Rows[i].ItemArray[1].ToString())
                {
                    clDataFile dat = new clDataFile(table.Rows[i].ItemArray[0].ToString());
                    return dat.GetFileToArrayByte();
                }
            }
            return null;
        }
        public static string GetPathCanceledFile()
        {
            DataTable table = new DataTable();
            table = clDataFile.GetListDataFile(clDataFile.ServiceIdClient);
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                if (LibDataFile.Properties.Settings.Default.ActWritingDown.ToString() == table.Rows[i].ItemArray[1].ToString())
                {
                    clDataFile dat = new clDataFile(table.Rows[i].ItemArray[0].ToString());
                    return dat.GetFileToArrayByte();
                }
            }
            return null;
        }
        public static string GetPathCloseKassaFile()
        {
            DataTable table = new DataTable();
            table = clDataFile.GetListDataFile(clDataFile.ServiceIdClient);
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                if (LibDataFile.Properties.Settings.Default.CloseKassa.ToString() == table.Rows[i].ItemArray[1].ToString())
                {
                    clDataFile dat = new clDataFile(table.Rows[i].ItemArray[0].ToString());
                    return dat.GetFileToArrayByte();
                }
            }
            return null;
        }
        // -------------------------------------------------------------------------------------------------------------------------------------------


        private static Bitmap bitmapFromDIB(IntPtr dibhand)
        {


            IntPtr bmpptr = GlobalLock(dibhand);
            IntPtr pixptr = GetPixelInfo(bmpptr);
            IntPtr pBmp = IntPtr.Zero;
            int status = GdipCreateBitmapFromGdiDib(bmpptr, pixptr, ref pBmp);
            if ((status == 0) && (pBmp != IntPtr.Zero))
            {


                MethodInfo mi = typeof(Bitmap).GetMethod("FromGDIplus", BindingFlags.Static | BindingFlags.NonPublic);
                if (mi == null) return null;
                Bitmap result = new Bitmap(mi.Invoke(null, new object[] { pBmp }) as Bitmap);
                GlobalFree(dibhand);
                dibhand = IntPtr.Zero;
                return result;

            }
            else return null;

        }
        private static IntPtr GetPixelInfo(IntPtr bmpptr)
        {


            BITMAPINFOHEADER bmi = new BITMAPINFOHEADER();
            Marshal.PtrToStructure(bmpptr, bmi);
            Rectangle bmprect = new Rectangle(0, 0, bmi.biWidth, bmi.biHeight);
            if (bmi.biSizeImage == 0) bmi.biSizeImage = ((((bmi.biWidth * bmi.biBitCount) + 31) & ~31) >> 3) * bmi.biHeight;
            int p = bmi.biClrUsed;
            if ((p == 0) && (bmi.biBitCount <= 8)) p = 1 << bmi.biBitCount;
            p = (p * 4) + bmi.biSize + (int)bmpptr;
            return (IntPtr)p;

        }
        [DllImport("gdiplus.dll", ExactSpelling = true)]
        private static extern int GdipCreateBitmapFromGdiDib(IntPtr bminfo, IntPtr pixdat, ref IntPtr image);
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GlobalLock(IntPtr handle);
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GlobalFree(IntPtr handle);
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        private class BITMAPINFOHEADER
        {


            public int biSize = 0;
            public int biWidth = 0;
            public int biHeight = 0;
            public short biPlanes = 0;
            public short biBitCount = 0;
            public int biCompression = 0;
            public int biSizeImage = 0;
            public int biXPelsPerMeter = 0;
            public int biYPelsPerMeter = 0;
            public int biClrUsed = 0;
            public int biClrImportant = 0;

        }
    }

}





