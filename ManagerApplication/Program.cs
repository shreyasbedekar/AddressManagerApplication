using System;
using System.Data.Entity;
using Wisej.Web;

namespace ManagerApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.Desktop = new MyDesktop();

            MainForm mainForm = new MainForm();
            mainForm.Show();

        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}