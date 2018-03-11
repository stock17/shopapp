﻿using shopapp.localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopapp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LanguageSettings.CurrentLanguage = LanguageSettings.ENGLISH;

            MainForm mainform = new MainForm();            
            Application.Run(mainform);     
            
        }
    }
}
