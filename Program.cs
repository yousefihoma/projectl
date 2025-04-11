﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Forms;

namespace LibraryApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //  Application.Run(new frmLogin());
            // Application.Run(new frmMain());
            Application.Run(new frmMembers());
            Application.Run(new frmBook());

        }
    }
}
