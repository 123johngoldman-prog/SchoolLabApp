using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;

namespace SchoolLabApp.Repositories.Implementations
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(SchoolLabAppDbContext context) : base(context) { }

        public async Task<IEnumerable<Person>> GetByTypeAsync(string type)
        {
            return await _dbSet
                .Where(p => p.Type == type)
                .ToListAsync();
        }
    }
}