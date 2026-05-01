using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories.Interfaces
{
    public interface ILoan<T> : IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetByAssetIdAsync(int assetId);

        Task<IEnumerable<T>> GetByPersonIdAsync(int personId);

        Task<IEnumerable<T>> GetActiveLoansAsync();

        Task<IEnumerable<T>> GetOverdueLoansAsync();
    }

}
