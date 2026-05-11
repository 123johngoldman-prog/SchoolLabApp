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

            // DbContext
            var context = new SchoolLabAppDbContext();

            // Repositories
            var userRepository = new UserRepository(context);

            // Services
            var userService = new UserService(userRepository);
            var roleService = new RoleService(context);

            // Run Register Form
            Application.Run(new Register(userService, roleService));
        }
    }
}