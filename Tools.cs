using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1Utility
{
    public static class Tools
//**************************************************************************
    {
        public static string GetLocalIP()
        {
            string localIP = "";
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork) // فقط IPv4
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting IP Address: " + ex.Message);
            }
            return localIP;
        }

        // چک کردن کد ملی
        public static void NationalCodeChek(string textBox1)
        {
            try
            {
                char[] chArray = textBox1.ToCharArray();
                int[] numArray = new int[chArray.Length];

                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                int num2 = numArray[9];

                switch (textBox1)
                {
                    case "0000000000":
                    case "1111111111":
                    case "22222222222":
                    case "33333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":

                        break;
                }
                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);

                int num4 = num3 - ((num3 / 11) * 11);

                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {

                }
                else
                {
                    MessageBox.Show("کد ملی نادرست است");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("لطفا کد ملی ده رقمی را وارد کنید");
            }
        }
        //test
        public static string sum(string t)
        {
            return (t);
        }

        // چک کردن پسورد قوی
        public static void CheckPasswordStrength(string password)
        {
            if ((password.Length < 8) || (!Regex.IsMatch(password, @"[A-Z]")) ||

         (!Regex.IsMatch(password, @"[a-z]")) || (!Regex.IsMatch(password, @"[0-9]"))
            || (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]")))
            {
                MessageBox.Show("رمز عبور صحیح را وارد کنید");
            }
        }


        private static void txtDigit(object sender, KeyPressEventArgs e)
        {
            //فقط عدد وارد شود 
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private static void txtPersian(object sender, KeyPressEventArgs e)
        {
            // فقط فارسی وارد شود
            if (e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                e.Handled = true;
            }
        }
    }
}
