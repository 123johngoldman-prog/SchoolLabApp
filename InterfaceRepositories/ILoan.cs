using SchoolLabApp.Models;
using SchoolLabApp.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.InterfaceRepositories
{
    public interface ILoan<T>:IBaseRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetByAssetIdAsync(int assetId);

        Task<IEnumerable<T>> GetByPersonIdAsync(int personId);

        Task<IEnumerable<T>> GetActiveLoansAsync();

        Task<IEnumerable<T>> GetOverdueLoansAsync();
    }
}
