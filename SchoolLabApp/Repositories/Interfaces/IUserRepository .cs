using SchoolLabApp.Models;
using System.Threading.Tasks;

namespace SchoolLabApp.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByUsernameAsync(string username);

        Task<User?> LoginAsync(string username, string password);
    }
}