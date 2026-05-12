using SchoolLabApp.Data;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Helpers;
using SchoolLabApp.Services;
using SchoolLabApp.View;

namespace SchoolLabApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            TechnicianPasswordManager.Initialize();

            Application.Run(new ReportPanel());
        }
    }
}