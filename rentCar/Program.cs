﻿using rentCar.views.car;
using System;
using System.Windows.Forms;

namespace rentCar
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
            Application.Run(new CarMantView());//new AppForm() //GeneralView
        }
    }
}