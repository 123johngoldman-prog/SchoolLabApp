using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories
{
    public interface IAssetRepo<T>:IBaseRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task GetStatus(T entity, int id);
        Task GetDateTime(T entity, int id);
    }
}
