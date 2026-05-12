using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Helpers;
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

            TechnicianPasswordManager.Initialize();

            var context = new SchoolLabAppDbContext();

            var userRepository = new UserRepository(context);

            var userService = new UserService(userRepository);
            var roleService = new RoleService(context);

            Application.Run(
                new Login(userService, roleService, context)
            );
        }
    }
}