using SchoolLabApp.Models;

namespace SchoolLabApp.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByUsernameAsync(string username);
        Task<User?> LoginAsync(string username, string password);
    }
}