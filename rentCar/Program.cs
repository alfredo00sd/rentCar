﻿using rentCar.user;
using rentCar.views;
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
            Application.Run(new userLogin());//new AppForm() //GeneralView //EmployeeForm //userLogin //InspectionForm
        }
    }
}
