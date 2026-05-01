using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories.Implementations
{
    public class LoanRepository:ILoan<Loan>
    {
        private readonly SchoolLabAppDbContext _context;

        public LoanRepository(SchoolLabAppDbContext context)
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

        public async Task<IEnumerable<Loan>> GetActiveLoansAsync()
        {
            return await _context.Loans
                .Where(l => l.Status.ToLower() == "active")
                .Include(l => l.Asset)
                .Include(l => l.Person)
                .ToListAsync();
        }

        public async Task<IEnumerable<Loan>> GetAllAsync()
        {
            return await _context.Loans
                .Include(l => l.Asset)
                .Include(l => l.Person)
                .ToListAsync();
        }

        public async Task<IEnumerable<Loan>> GetByAssetIdAsync(int assetId)
        {
            return await _context.Loans
                .Where(l => l.AssetId == assetId)
                .Include(l => l.Person)
                .ToListAsync();
        }

        public async Task<Loan?> GetByIdAsync(int id)
        {
            return await _context.Loans
                .Include(l => l.Asset)
                .Include(l => l.Person)
                .FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<IEnumerable<Loan>> GetByPersonIdAsync(int personId)
        {
            return await _context.Loans
                .Where(l => l.PersonId == personId)
                .Include(l => l.Asset)
                .ToListAsync();
        }

        public async Task<IEnumerable<Loan>> GetOverdueLoansAsync()
        {
            {
                return await _context.Loans
                    .Where(l => l.Status.ToLower() == "overdue")
                    .Include(l => l.Asset)
                    .Include(l => l.Person)
                    .ToListAsync();
            }
        }
    }
}
