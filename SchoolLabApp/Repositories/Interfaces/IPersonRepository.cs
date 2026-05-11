using SchoolLabApp.Models;

namespace SchoolLabApp.Repositories.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<IEnumerable<Person>> GetByTypeAsync(string type);
    }
}