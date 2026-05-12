using Moq;
using NUnit.Framework;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;

[TestFixture]
public class AssetServiceTests
{
    private Mock<AssetRepository> _repoMock;
    private AssetService _service;

    [SetUp]
    public void Setup()
    {
        _repoMock = new Mock<AssetRepository>();
        _service = new AssetService(_repoMock.Object);
    }

    [Test]
    public void AddAssets_ShouldThrow_WhenNameIsEmpty()
    {
        Assert.ThrowsAsync<ArgumentException>(() =>
            _service.AddAssets("", "Available", 1));
    }

    [Test]
    public async Task AddAssets_ShouldCallRepository()
    {
        await _service.AddAssets("Laptop", "Available", 1);

        _repoMock.Verify(r => r.AddAsync(It.IsAny<Asset>()), Times.Once);
    }

    [Test]
    public void UpdateAsset_ShouldThrow_WhenNotFound()
    {
        _repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                 .ReturnsAsync((Asset)null);

        Assert.ThrowsAsync<InvalidOperationException>(() =>
            _service.UpdateAsset(new Asset { Id = 1 }));
    }
}