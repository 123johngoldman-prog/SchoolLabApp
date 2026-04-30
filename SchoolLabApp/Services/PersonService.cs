using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;

namespace SchoolLabApp.Services
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepo;

        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public async Task AddAsync(Person person)
        {
            await _personRepo.AddAsync(person);
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _personRepo.GetAllAsync();
        }

        public async Task<IEnumerable<Person>> GetStudentsAsync()
        {
            return await _personRepo.GetByTypeAsync("Student");
        }

        public async Task<IEnumerable<Person>> GetTeachersAsync()
        {
            return await _personRepo.GetByTypeAsync("Teacher");
        }
    }
}