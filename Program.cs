using Microsoft.Data.SqlClient;
using System.Data;

namespace Lab_10
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        
        public static void Main()
        {

            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmCompany());

            
        }
    }
}