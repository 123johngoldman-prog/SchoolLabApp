namespace SchoolLabApp.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        IPersonRepository Persons { get; }

        IAssetRepository Assets { get; }

        ILoanRepository Loans { get; }

        IDamageRepository Damages { get; }

        ICategoryRepository Categories { get; }

        IRoleRepository Roles { get; }

        Task SaveAsync();
    }
}