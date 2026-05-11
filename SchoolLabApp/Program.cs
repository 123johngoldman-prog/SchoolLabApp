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
            DbSeeder.Seed(context);

            var userRepo    = new UserRepository(context);
            var userService = new UserService(userRepo);
            var roleService = new RoleService(context);

            Application.Run(new Login(userService, roleService, context));
        }
    }
}
