﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IntegradorWebService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// key for pfx
        /// rewq987aa
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
