using System;
using System.Collections.Generic;
using System.Text;
using SchoolLabApp.Models;

namespace SchoolLabApp.Repositories
{
    public interface IRoleRepository<T>: IBaseRepo<T> where T : class
    {
        Task<IEnumerable<Role>> GetAllAsync();
        Task<Role?> GetByIdAsync(int id);
        Task AddAsync(Role role);
        Task UpdateAsync(Role role);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}