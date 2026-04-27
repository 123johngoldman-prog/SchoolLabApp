using SchoolLabApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Repositories.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<List<Person>> GetStudentsAsync();

        Task<List<Person>> GetTeachersAsync();
    }
}