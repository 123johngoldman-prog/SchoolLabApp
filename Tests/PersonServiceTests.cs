using Moq;
using NUnit.Framework;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{

    [TestFixture]
    public class PersonServiceTests
    {
        private Mock<PersonRepository> _repoMock;
        private PersonService _service;

        [SetUp]
        public void SetUp()
        {
            _repoMock = new Mock<PersonRepository>(MockBehavior.Strict, null!);
            _service = new PersonService(_repoMock.Object);
        }

        // ── AddPerson ────────────────────────────────────────────────────────

        [Test]
        public async Task AddPerson_ValidPerson_CallsAddAsync()
        {
            var person = new Person { Name = "John", Type = "Student" };
            _repoMock.Setup(r => r.AddAsync(person)).Returns(Task.CompletedTask);

            await _service.AddPerson(person);

            _repoMock.Verify(r => r.AddAsync(person), Times.Once);
        }

        [Test]
        public async Task AddPerson_NullPerson_DoesNotCallAddAsync()
        {
            // PersonService swallows the exception
            await _service.AddPerson(null!);

            _repoMock.Verify(r => r.AddAsync(It.IsAny<Person>()), Times.Never);
        }

        [Test]
        public async Task AddPerson_EmptyName_DoesNotCallAddAsync()
        {
            var person = new Person { Name = "  ", Type = "Student" };
            await _service.AddPerson(person);

            _repoMock.Verify(r => r.AddAsync(It.IsAny<Person>()), Times.Never);
        }

        [Test]
        public async Task AddPerson_EmptyType_DoesNotCallAddAsync()
        {
            var person = new Person { Name = "John", Type = "" };
            await _service.AddPerson(person);

            _repoMock.Verify(r => r.AddAsync(It.IsAny<Person>()), Times.Never);
        }

        // ── GetAllPersons / GetStudents / GetTeachers ─────────────────────────

        [Test]
        public async Task GetAllPersons_ReturnsAll()
        {
            _repoMock.Setup(r => r.GetAllAsync())
                     .ReturnsAsync(new List<Person> { new Person(), new Person() });

            var result = await _service.GetAllPersons();

            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task GetStudents_ReturnsStudents()
        {
            var students = new List<Person> { new Person { Type = "Student" } };
            _repoMock.Setup(r => r.GetByTypeAsync("Student")).ReturnsAsync(students);

            var result = await _service.GetStudents();

            Assert.That(result.All(p => p.Type == "Student"));
        }

        [Test]
        public async Task GetTeachers_ReturnsTeachers()
        {
            var teachers = new List<Person> { new Person { Type = "Teacher" } };
            _repoMock.Setup(r => r.GetByTypeAsync("Teacher")).ReturnsAsync(teachers);

            var result = await _service.GetTeachers();

            Assert.That(result.All(p => p.Type == "Teacher"));
        }

        // ── UpdatePerson ─────────────────────────────────────────────────────

        [Test]
        public async Task UpdatePerson_ExistingPerson_CallsUpdateAsync()
        {
            var person = new Person { Id = 1, Name = "Jane", Type = "Teacher" };
            _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(person);
            _repoMock.Setup(r => r.UpdateAsync(person)).Returns(Task.CompletedTask);

            await _service.UpdatePerson(person);

            _repoMock.Verify(r => r.UpdateAsync(person), Times.Once);
        }

        [Test]
        public async Task UpdatePerson_NotFound_DoesNotCallUpdateAsync()
        {
            var person = new Person { Id = 99 };
            _repoMock.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Person?)null);

            await _service.UpdatePerson(person);

            _repoMock.Verify(r => r.UpdateAsync(It.IsAny<Person>()), Times.Never);
        }

        // ── DeletePerson ─────────────────────────────────────────────────────

        [Test]
        public async Task DeletePerson_ExistingId_CallsDeleteAsync()
        {
            _repoMock.Setup(r => r.GetByIdAsync(4)).ReturnsAsync(new Person { Id = 4 });
            _repoMock.Setup(r => r.DeleteAsync(4)).Returns(Task.CompletedTask);

            await _service.DeletePerson(4);

            _repoMock.Verify(r => r.DeleteAsync(4), Times.Once);
        }

        [Test]
        public async Task DeletePerson_NotFound_DoesNotCallDeleteAsync()
        {
            _repoMock.Setup(r => r.GetByIdAsync(88)).ReturnsAsync((Person?)null);

            await _service.DeletePerson(88);

            _repoMock.Verify(r => r.DeleteAsync(It.IsAny<int>()), Times.Never);
        }
    }
}