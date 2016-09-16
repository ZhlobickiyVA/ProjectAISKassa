using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace UtilDLL
{

    public static class CLUtils
    {

        public static string GetPathTemp()
        {
            string tempdirect = Path.GetTempPath();
            string path = tempdirect+"KassaAIS";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            return path;
        }



        public static List<String> GetListMonth()
        {
            List<String> Month = new List<string>();

            Month.Add("Без фильтра");
            Month.Add("Январь");
            Month.Add("Февраль");
            Month.Add("Март");
            Month.Add("Апрель");
            Month.Add("Май");
            Month.Add("Июнь");
            Month.Add("Июль");
            Month.Add("Август");
            Month.Add("Сентябрь");
            Month.Add("Октябрь");
            Month.Add("Ноябрь");
            Month.Add("Декабрь");

            return Month;
        }

        
        

        public static string GetTempDic = "Temp";

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            form.StartPosition = FormStartPosition.CenterParent;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static string GetSep()
        {
            return NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
        }
        


    }
}
