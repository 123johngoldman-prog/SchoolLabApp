using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;

namespace SchoolLabApp.Services
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;

        public PersonService(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task AddPerson(Person person)
        {
            try
            {
                if (person == null)
                {
                    throw new Exception("Person is null");
                }

                if (string.IsNullOrWhiteSpace(person.Name))
                {
                    throw new Exception("Name is required");
                }

                if (string.IsNullOrWhiteSpace(person.Type))
                {
                    throw new Exception("Type is required");
                }

                await _personRepository.AddAsync(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            try
            {
                return await _personRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Person>();
            }
        }

        public async Task<IEnumerable<Person>> GetStudents()
        {
            try
            {
                return await _personRepository.GetByTypeAsync("Student");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Person>();
            }
        }

        public async Task<IEnumerable<Person>> GetTeachers()
        {
            try
            {
                return await _personRepository.GetByTypeAsync("Teacher");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Person>();
            }
        }

        public async Task UpdatePerson(Person person)
        {
            try
            {
                var existingPerson = await _personRepository.GetByIdAsync(person.Id);

                if (existingPerson == null)
                {
                    throw new Exception("Person not found");
                }

                await _personRepository.UpdateAsync(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeletePerson(int id)
        {
            try
            {
                var existingPerson = await _personRepository.GetByIdAsync(id);

                if (existingPerson == null)
                {
                    throw new Exception("Person not found");
                }

                await _personRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}