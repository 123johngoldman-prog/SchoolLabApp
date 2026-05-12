using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
            => _roleRepository = roleRepository;

        public async Task AddRole(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Role name cannot be empty.");

            var role = new Role { Name = name };
            await _roleRepository.AddAsync(role);
        }

        public async Task UpdateRole(Role role)
        {
            if (await _roleRepository.GetByIdAsync(role.Id) == null)
                throw new InvalidOperationException("Role not found.");
            await _roleRepository.UpdateAsync(role);
        }

        public async Task DeleteRole(int id)
        {
            if (await _roleRepository.GetByIdAsync(id) == null)
                throw new InvalidOperationException("Role not found.");
            await _roleRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Role>> GetAll()
            => await _roleRepository.GetAllAsync();

        public async Task<Role?> GetById(int id)
            => await _roleRepository.GetByIdAsync(id);

        public async Task<bool> Exists(int id)
            => await _roleRepository.ExistsAsync(id);
    }
}