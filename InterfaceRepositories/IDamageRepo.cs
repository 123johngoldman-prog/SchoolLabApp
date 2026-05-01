using System;
using System.Collections.Generic;
using System.Text;

using SchoolLabApp.Models;

namespace SchoolLabApp.Repositories
{
    public interface IDamageRepository<T>:IBaseRepo<T> where T : class 
    {
        Task<IEnumerable<Damage>> GetAllAsync();
        Task<Damage?> GetByIdAsync(int id);
        Task AddAsync(Damage damage);
        Task UpdateAsync(Damage damage);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}