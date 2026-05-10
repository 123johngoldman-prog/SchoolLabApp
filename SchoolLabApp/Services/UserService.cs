using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Register(User user)
        {
            try
            {
                if (user == null)
                {
                    throw new Exception("User is null");
                }

                if (string.IsNullOrWhiteSpace(user.Username))
                {
                    throw new Exception("Username is required");
                }

                if (string.IsNullOrWhiteSpace(user.Password))
                {
                    throw new Exception("Password is required");
                }

                var existingUser = await _userRepository.GetByUsernameAsync(user.Username);

                if (existingUser != null)
                {
                    throw new Exception("Username already exists");
                }

                await _userRepository.AddAsync(user);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<User?> Login(string username, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new Exception("Username is required");
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new Exception("Password is required");
                }

                var user = await _userRepository.LoginAsync(username, password);

                if (user == null)
                {
                    throw new Exception("Invalid username or password");
                }

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                return await _userRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<User>();
            }
        }

        public async Task UpdateUser(User user)
        {
            try
            {
                var existingUser = await _userRepository.GetByIdAsync(user.Id);

                if (existingUser == null)
                {
                    throw new Exception("User not found");
                }

                await _userRepository.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeleteUser(int id)
        {
            try
            {
                var existingUser = await _userRepository.GetByIdAsync(id);

                if (existingUser == null)
                {
                    throw new Exception("User not found");
                }

                await _userRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}