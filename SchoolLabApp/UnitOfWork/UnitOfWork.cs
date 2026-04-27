using SchoolLabApp.Data;
using SchoolLabApp.Repositories.Interfaces;

namespace SchoolLabApp.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolLabAppDbContext _context;

        public IUserRepository Users { get; }
        public IPersonRepository Persons { get; }
        public IAssetRepository Assets { get; }
        public ILoanRepository Loans { get; }
        public IDamageRepository Damages { get; }
        public ICategoryRepository Categories { get; }
        public IRoleRepository Roles { get; }

        public UnitOfWork(SchoolLabAppDbContext context)
        {
            _context = context;

            Users = new UserRepository(_context);
            Persons = new PersonRepository(_context);
            Assets = new AssetRepository(_context);
            Loans = new LoanRepository(_context);
            Damages = new DamageRepository(_context);
            Categories = new CategoryRepository(_context);
            Roles = new RoleRepository(_context);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}