using Moq;
using NUnit.Framework;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;
using SchoolLabApp.Services;
using System.Threading.Tasks;

[TestFixture]
public class UserServiceTests
{
    private Mock<IUserRepository> _repoMock;
    private UserService _service;

    [SetUp]
    public void Setup()
    {
        _repoMock = new Mock<IUserRepository>();
        _service = new UserService(_repoMock.Object);
    }

    [Test]
    public async Task Register_ValidUser_CallsRepository()
    {
        var user = new User
        {
            Username = "test",
            Password = "123",
            RoleId = 1
        };

        _repoMock.Setup(x => x.GetByUsernameAsync("test"))
                 .ReturnsAsync((User)null);

        await _service.Register(user);

        _repoMock.Verify(x => x.GetByUsernameAsync("test"), Times.Once);
    }
}