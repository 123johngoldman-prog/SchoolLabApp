using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories.Interfaces
{
    public interface IAssetRepository<T>: IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetByStatusAsync(string status);
        Task<IEnumerable<T>> GetByCategoryIdAsync(int categoryId);
        Task<T?> GetByInventoryNumberAsync(string inventoryNumber);
    }
}
