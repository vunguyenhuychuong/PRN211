using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System;

namespace MyStoreWinApp
{
     static class Program
    {

        public static IConfiguration Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}