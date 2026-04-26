using SchoolLabApp.Data;
using SchoolLabApp.InterfaceRepositories;
using SchoolLabApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Service
{
    public class LoanService:ILoan<Loan>
    {
        private readonly SchoolLabAppDbContext _context;

        public LoanService(SchoolLabAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Loan loan)
        {
            _context.Loans.AddAsync(loan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Loan loan)
        {
            _context.Loans.Update(loan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
                await _context.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<Loan>> GetActiveLoansAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Loan>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Loan>> GetByAssetIdAsync(int assetId)
        {
            throw new NotImplementedException();
        }

        public Task<Loan?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Loan>> GetByPersonIdAsync(int personId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Loan>> GetOverdueLoansAsync()
        {
            throw new NotImplementedException();
        }

    }
}
