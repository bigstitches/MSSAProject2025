using Microsoft.EntityFrameworkCore;
using YarnCodeFirst.Data;

namespace YarnCodeFirst
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Records.yarnContext = new YarnContext();
            Records.yarnContext.Database.EnsureCreated();
            Records.yarnContext.Yarns.Load();
            Records.yarnContext.Manufacturers.Load();

            Application.Run(new Form1());
        }
    }
}