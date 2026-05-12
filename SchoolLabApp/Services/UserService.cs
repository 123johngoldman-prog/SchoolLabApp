using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;

namespace SchoolLabApp.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Register(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentException("Username is required.");
            }
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password is required.");
            }
            if (user.RoleId <= 0)
            {
                throw new ArgumentException("A valid role must be selected.");
            }

            var existing = await _userRepository.GetByUsernameAsync(user.Username);
            if (existing != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }

            await _userRepository.AddAsync(user);
        }

        public async Task<User> Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username is required.");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password is required.");
            }

            var user = await _userRepository.LoginAsync(username, password);
            if (user == null)
            {
                throw new InvalidOperationException("Invalid username or password.");
            }

            return user;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        { 
            return await _userRepository.GetAllAsync();
        }

        public async Task UpdateUser(User user)
        {
            if (await _userRepository.GetByIdAsync(user.Id) == null)
            {
                throw new InvalidOperationException("User not found.");
            }
            await _userRepository.AddAsync(user);
            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUser(int id)
        {
            if (await _userRepository.GetByIdAsync(id) == null)
            {
                throw new InvalidOperationException("User not found.");
            }

            await _userRepository.DeleteAsync(id);
        }
    }
}
