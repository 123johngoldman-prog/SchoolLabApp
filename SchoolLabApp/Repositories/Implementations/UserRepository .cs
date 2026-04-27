using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;
using System.Threading.Tasks;

namespace SchoolLabApp.Repositories.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SchoolLabAppDbContext context)
            : base(context)
        {
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _dbSet
                .Include(u => u.Role)
                .Include(u => u.Person)
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User?> LoginAsync(string username, string password)
        {
            return await _dbSet
                .Include(u => u.Role)
                .Include(u => u.Person)
                .FirstOrDefaultAsync(u =>
                    u.Username == username &&
                    u.Password == password);
        }
    }
}