//using App.WindowsApp.Forms;

//namespace App.WindowsApp
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
//            Application.Run(new MainForm());
//        }
//    }
//}


using App.Core.Contracts;
using App.Core.Services;
using App.WindowsApp.Forms;
using App.WindowsApp.Views;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace App.WindowsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 🔥 SERVICE YAHAN BANANI HAI
            //ICustomerService service = new CustomerService();

            // 🔥 VIEW KO PASS KARO
            Application.Run(new MainForm());
        }
    }
}