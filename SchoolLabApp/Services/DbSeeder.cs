using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;

namespace SchoolLabApp.Services
{
    public static class DbSeeder
    {
        public static void Seed(SchoolLabAppDbContext context)
        {
            context.Database.Migrate();           // apply pending migrations
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role { Name = "Student" },
                    new Role { Name = "Teacher" },
                    new Role { Name = "Technician" }
                );
                context.SaveChanges();
            }
        }
    }
}
