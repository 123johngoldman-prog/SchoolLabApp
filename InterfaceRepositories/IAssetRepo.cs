using SchoolLabApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories
{
    public interface IAssetRepo<T>:IBaseRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetByStatusAsync(string status);
        Task<IEnumerable<T>> GetByCategoryIdAsync(int categoryId);
        Task<T?> GetByInventoryNumberAsync(string inventoryNumber);
    }
}
