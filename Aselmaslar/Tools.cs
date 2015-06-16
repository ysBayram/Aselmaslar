using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Aselmaslar
{
    public class Tools
    {
        public static string change(string dosyaAdi)
        {
            //Bu metodumuzlada Türkçe karakterleri temizleyip ingilizceye uyarlıyoruz
            string Temp = dosyaAdi.ToLower();

            Temp = Temp.Replace("-", "").ToString();Temp = Temp.Replace(" ", "-").ToString();Temp = Temp.Replace("ç", "c").ToString(); Temp = Temp.Replace("ğ", "g").ToString();Temp = Temp.Replace("ı", "i").ToString(); Temp = Temp.Replace("ö", "o").ToString();Temp = Temp.Replace("ş", "s").ToString(); Temp = Temp.Replace("ü", "u").ToString();Temp = Temp.Replace("\"", "").ToString(); Temp = Temp.Replace("/", "").ToString();Temp = Temp.Replace("(", "").ToString(); Temp = Temp.Replace(")", "").ToString();Temp = Temp.Replace("{", "").ToString(); Temp = Temp.Replace("}", "").ToString();Temp = Temp.Replace("%", "").ToString(); Temp = Temp.Replace("&", "").ToString();Temp = Temp.Replace("+", "").ToString(); Temp = Temp.Replace(",", "").ToString();Temp = Temp.Replace("?", "").ToString(); Temp = Temp.Replace(".", "_").ToString();Temp = Temp.Replace("ı", "i").ToString();Temp = Temp.Replace("!", "").ToString();Temp = Temp.Replace("#", "").ToString();Temp = Temp.Replace("$", "").ToString();Temp = Temp.Replace("Ğ", "G").ToString();Temp = Temp.Replace("Ç", "C").ToString();Temp = Temp.Replace("İ", "I").ToString();Temp = Temp.Replace("Ş", "S").ToString();Temp = Temp.Replace("Ü", "U").ToString();Temp = Temp.Replace("Ö", "O").ToString();Temp = Temp.Replace(":", "-").ToString();
            return Temp;
        }

        public static string ControlLength(string word, int length)
        {
            if (word.Length > length){return word.Substring(0, length - 3);}else{return word;}
        }

        public static void SadeceNoGir(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)) e.Handled = true;
        }

        public static void SadeceYaziGir(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        public static void SadeceTarihGir(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) e.Handled = true;
        }

        public static void gwDoldur(string sql, DataGridView gv)
        {
            System.Data.DataTable dt = Islemler.NAKLIYEIslem.VeriKumesi(sql);
            if (dt != null) { gv.DataSource = dt.DefaultView; }
            else { gv.DataSource = null; }
        }

        public static void cmbDoldur(string sql, ComboBox ddl, string displayMember, string valueMember)
        {
            System.Data.DataTable dt = Islemler.NAKLIYEIslem.VeriKumesi(sql);
            if (dt != null) 
            {
                DataRow row = dt.NewRow();
                row[displayMember] = ""; 
                dt.Rows.InsertAt(row, 0);
                ddl.DataSource = dt.DefaultView; ddl.DisplayMember = displayMember; ddl.ValueMember = valueMember;             
            }
            else { ddl.DataSource = null; }
        }

        public static void ExportToExcel(DataGridView dgv, string path)
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRange;

            // Start Excel and get Application object. 
            oXL = new Excel.Application();

            // Set some properties 
            oXL.Visible = false;
            oXL.DisplayAlerts = false;

            // Get a new workbook. 
            oWB = oXL.Workbooks.Add(Missing.Value);

            // Get the active sheet 
            oSheet = (Excel.Worksheet)oWB.ActiveSheet;
            oSheet.Name = "As Elmaslar";

            //Header Style
            Excel.Style hs = oSheet.Application.ActiveWorkbook.Styles.Add("Header");
            hs.Font.Bold = true;
            hs.ShrinkToFit = true;
            hs.WrapText = false;
            hs.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            hs.Interior.Color = System.Drawing.Color.LightBlue;
            
            int rows = dgv.Rows.Count;
            int columns = dgv.Columns.Count;
            var data = new object[rows, columns];
            for (var row = 1; row <= rows; row++)
            {
                for (var column = 1; column <= columns; column++)
                {
                    if (row == 2)
                    {
                        oSheet.Cells[1, column] = dgv.Columns[column - 1].HeaderText;
                        oSheet.Cells[1, column].Style = "Header";
                    }
                    if (column == 2)
                    {
                        data[row - 1, column - 1] = dgv.Rows[row - 1].Cells[column - 1].Value.ToString().Replace("-", ".");    
                    }
                    else if (column == 12)
                    {
                        //tonaj kolonunu sayı olarak yolluyorum excele
                        data[row - 1, column - 1] = (Double)dgv.Rows[row - 1].Cells[column - 1].Value;
                    }
                    else
                    {
                        data[row - 1, column - 1] = dgv.Rows[row - 1].Cells[column - 1].Value.ToString();
                    }
                }
            }

            var startCell = (Excel.Range)oSheet.Cells[2, 1];
            var endCell = (Excel.Range)oSheet.Cells[rows + 1, columns];
            var writeRange = oSheet.Range[startCell, endCell];

            writeRange.Value2 = data;

            //Resize the columns 
            oSheet.Cells.EntireColumn.AutoFit();
            oSheet.Cells.EntireRow.AutoFit();
            
            // Save the sheet and close 
            oSheet = null;
            oRange = null;
            oWB.SaveAs(path, Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oWB.Close(Missing.Value, Missing.Value, Missing.Value);
            oWB = null;
            oXL.Quit();

            // Clean up 
            // NOTE: When in release mode, this does the trick 
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        public static void sendMail(string name, string email, string subject, string message)
        {
            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    mail.To.Add(ADMINCRUD.IdyeGoreADMINGetir(1).MAIL);
            //    mail.From = new MailAddress(email, name);
            //    mail.Subject = subject;
            //    mail.Body = message;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Port = 587;
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    smtp.EnableSsl = true;
            //    smtp.UseDefaultCredentials = false;
            //    System.Net.NetworkCredential yetki = new System.Net.NetworkCredential("robotpoyraz@gmail.com", "00poyraz99");
            //    smtp.Credentials = yetki;
            //    smtp.Send(mail);
            //    HttpContext.Current.Response.Write("<script>alert('Mailiniz başarılı bir şekilde gönderilmiştir!')</script>");
            //}
            //catch (Exception e)
            //{
            //    HttpContext.Current.Response.Write("<script>alert('" + e.Message + "')</script>");
            //}

        }        
        
    }


    /* Bu Class Mouse un bekleme pozisyonununa almaya yarıyor kullanımı:
     * using (new WaitCursor()){-----buraya kodlarını yaz -----}    
    */
    public class WaitCursor : IDisposable
    {
        public WaitCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
        }
        public void Dispose()
        {
            Cursor.Current = Cursors.Default;
        }
    }
}