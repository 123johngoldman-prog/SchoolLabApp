using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;

namespace SchoolLabApp.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<User?> LoginAsync(string username, string password)
        {
            return await _userRepo.LoginAsync(username, password);
        }

        public async Task<bool> RegisterAsync(User user)
        {
            var existing = await _userRepo.GetByUsernameAsync(user.Username);

            if (existing != null)
                return false;

            await _userRepo.AddAsync(user);
            return true;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepo.GetAllAsync();
        }
    }
}