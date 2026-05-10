using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Services
{
    public class LoanService
    {
        private readonly LoanRepository _loanRepository;

        public LoanService(LoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task AddLoan(int AssetId, int PersonId, string status)
        {
            try
            {
                Loan loan = new Loan()
                {
                    AssetId = AssetId,
                    PersonId = PersonId,
                    StartDate = DateTime.Now,
                    Status = status
                };

                await _loanRepository.AddAsync(loan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task UpdateLoan(Loan loan)
        {
            try
            {
                var loans = await _loanRepository.GetByIdAsync(loan.Id);

                if (loans == null)
                {
                    throw new Exception("Loan not found");
                }

                await _loanRepository.UpdateAsync(loan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeleteLoan(int id)
        {
            try
            {
                var loans = await _loanRepository.GetByIdAsync(id);

                if (loans == null)
                {
                    throw new Exception("Loan not found");
                }

                await _loanRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<IEnumerable<Loan>> GetLoanByStatus(string status)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(status))
                {
                    throw new Exception("Must enter status");
                }
                if (status.ToLower() != "active"
                        && status.ToLower() != "unactive"
                        && status.ToLower() != "borken")
                {
                    throw new Exception("Status doesnt exsist");
                }

                return await _loanRepository.GetLoansByStatusAsync(status);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<Loan>();
            }
        }
    }
}
