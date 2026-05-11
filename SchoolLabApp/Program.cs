using SchoolLabApp.Data;
using SchoolLabApp.Repositories.Implementations;
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

            var context = new SchoolLabAppDbContext();

            var assetRepository = new AssetRepository(context);

            var assetService = new AssetService(assetRepository);

            Application.Run(new TechnicianPanel(assetService));

            //TO DO: Main :D
        }
    }
}
