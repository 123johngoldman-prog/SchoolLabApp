using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class LoanService
    {
        private readonly LoanRepository _loanRepository;

        public LoanService(LoanRepository loanRepository)
            => _loanRepository = loanRepository;

        public async Task AddLoan(int assetId, int personId, int durationDays, string status)
        {
            var loan = new Loan
            {
                AssetId   = assetId,
                PersonId  = personId,
                StartDate = DateTime.Now,
                DurationDays = durationDays,
                Status    = status
            };
            await _loanRepository.AddAsync(loan);
        }

        public async Task ReturnLoan(int loanId)
        {
            var loan = await _loanRepository.GetByIdAsync(loanId);

            if (loan == null)
            {
                throw new InvalidOperationException("Loan not found.");
            }

            loan.Status       = "Returned";
            loan.ReturnedDate = DateTime.Now;

            await _loanRepository.UpdateAsync(loan);
        }

        public async Task<IEnumerable<Loan>> GetLoansByPerson(int personId)
        {
            return await _loanRepository.GetByPersonIdAsync(personId);
        }

        public async Task<IEnumerable<Loan>> GetAll()
        {
            return await _loanRepository.GetAllAsync();
        }

        public async Task UpdateLoan(Loan loan)
        {
            if (await _loanRepository.GetByIdAsync(loan.Id) == null)
            {
                throw new InvalidOperationException("Loan not found.");
            }

            await _loanRepository.UpdateAsync(loan);
        }

        public async Task DeleteLoan(int id)
        {
            if (await _loanRepository.GetByIdAsync(id) == null)
            {
                throw new InvalidOperationException("Loan not found.");
            }
            await _loanRepository.DeleteAsync(id);
        }
    }
}
