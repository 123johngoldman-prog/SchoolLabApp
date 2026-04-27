using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLabApp.Repositories.Implementations
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(SchoolLabAppDbContext context)
            : base(context)
        {
        }

        public async Task<List<Person>> GetStudentsAsync()
        {
            return await _dbSet
                .Where(p => p.Type == "Student")
                .ToListAsync();
        }

        public async Task<List<Person>> GetTeachersAsync()
        {
            return await _dbSet
                .Where(p => p.Type == "Teacher")
                .ToListAsync();
        }
    }
}