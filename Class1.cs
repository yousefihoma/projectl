using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1Utility
{
    public class Class1
    {//*******            this.Name = "frmMembers";**********************
        ////print
        //void Print()
        //{
        //    PrintDocument printDocument = new PrintDocument();
        //    PrintDialog printDialog = new PrintDialog();
        //    printDocument.PrintPage += PrintDocument_PrintPage;
        //    printDialog.Document = printDocument;

        //    if (printDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        printDocument.Print();
        //    }
        //}
        //private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    UserControl pictureBox1 = new UserControl();
        //    using (Bitmap myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height))
        //    {
        //        pictureBox1.DrawToBitmap(myBitmap,
        //            new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
        //        e.Graphics.DrawImage(myBitmap, 0, 0);
        //    }


        //} //************* ***
        ////این متد تعداد کاراکترهای متن ورودی را کنترل می کند
        //static string summerizedText(String text, int maxLenght)
        //{
        //    if (text.Length < maxLenght)
        //    {
        //        return text;
        //    }

        //    var words = text.Split(' ');
        //    var totalCharacter = 0;
        //    var summery = new List<string>();
        //    foreach (var word in words)
        //    {
        //        summery.Add(word);
        //        totalCharacter += word.Length + 1;
        //        if (totalCharacter > maxLenght)
        //        {
        //            break;
        //        }

        //    }
        //    return string.Join(" ", summery) + "...";

        //    //بعد    string str ="ونمنامههام" ;    textBox1.Text = summerizedText(str, 100);    


        //}

        ////***************************
        //// SendEmail

        //void Send(string txtFrom, string txtPassword1, string txtTo, string richtxtMessage)
        //{
        //    try
        //    {
        //        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //        client.EnableSsl = true;
        //        client.Credentials = new NetworkCredential(txtFrom, txtPassword1);

        //        MailAddress from = new MailAddress(txtFrom);
        //        MailAddress to = new MailAddress(txtTo);
        //        MailMessage message = new MailMessage(from, to);
        //        message.Body = richtxtMessage;
        //        message.BodyEncoding = Encoding.UTF8;
        //        message.Subject = txtSubject.Text;
        //        message.SubjectEncoding = Encoding.UTF8;
        //        client.Send(message);
        //        message.Dispose();
        //        MessageBox.Show("Message Sent!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        ////*******************************************
        ////این متد اعداد را در هر صورت، فارسی نمایش می دهد
        //string GetPersianNumber(string englishNumber)
        //{
        //    string persianNumber = "";
        //    foreach (char ch in englishNumber)
        //    {
        //        persianNumber += (char)(1776 + char.GetNumericValue(ch));

        //    }

        //    return persianNumber;
        //}
        //string GetEnglishNumber(string persianNumber)
        //{
        //    string englishNumber = "";
        //    foreach (char ch in persianNumber)
        //    {
        //        englishNumber += (char.GetNumericValue(ch));
        //    }

        //    return englishNumber;
        //}
        //// بعد    txtNumber.Text = GetEnglishNumber(textBox1.Text);



        ////**************************
        private void txtDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //فقط عدد وارد شود. MaxLenght طول هم محدود شده
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // فقط فارسی وارد شود
            if (e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                e.Handled = true;
            }
            ////}
            ////**************************
            ////با کلیک روی سلول در دیتاگرید، همه سطر انتخاب می شود، متد استایل دیتاگرید در دوره 31 دوره UIUX
            ////private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
            ////{
            ////    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ////}
        }
    }
}
