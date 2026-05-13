using Moq;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

[TestFixture]
public class AssetServiceTests
{
    private Mock<AssetRepository> _repoMock;
    private AssetService _service;

    [SetUp]
    public void SetUp()
    {
      
        _repoMock = new Mock<AssetRepository>(MockBehavior.Strict,null!);
        _service = new AssetService(_repoMock.Object);
    }

    // ── AddAssets ────────────────────────────────────────────────────────

    [Test]
    public async Task AddAssets_ValidInput_CallsAddAsync()
    {
        _repoMock.Setup(r => r.AddAsync(It.IsAny<Asset>())).Returns(Task.CompletedTask);

        await _service.AddAssets("Laptop", "Available", 1);

        _repoMock.Verify(r => r.AddAsync(It.Is<Asset>(a =>
            a.Name == "Laptop" && a.Status == "Available" && a.CategoryId == 1)), Times.Once);
    }

    [Test]
    public void AddAssets_EmptyName_ThrowsArgumentException()
    {
        Assert.ThrowsAsync<ArgumentException>(() => _service.AddAssets("  ", "Available", 1));
    }

    // ── UpdateAsset ──────────────────────────────────────────────────────

    [Test]
    public async Task UpdateAsset_ExistingAsset_CallsUpdateAsync()
    {
        var asset = new Asset { Id = 1, Name = "Monitor" };
        _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(asset);
        _repoMock.Setup(r => r.UpdateAsync(asset)).Returns(Task.CompletedTask);

        await _service.UpdateAsset(asset);

        _repoMock.Verify(r => r.UpdateAsync(asset), Times.Once);
    }

    [Test]
    public void UpdateAsset_NotFound_ThrowsInvalidOperationException()
    {
        var asset = new Asset { Id = 99 };
        _repoMock.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Asset?)null);

        Assert.ThrowsAsync<InvalidOperationException>(() => _service.UpdateAsset(asset));
    }

    // ── DeleteAsset ──────────────────────────────────────────────────────

    [Test]
    public async Task DeleteAsset_ExistingId_CallsDeleteAsync()
    {
        _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(new Asset { Id = 1 });
        _repoMock.Setup(r => r.DeleteAsync(1)).Returns(Task.CompletedTask);

        await _service.DeleteAsset(1);

        _repoMock.Verify(r => r.DeleteAsync(1), Times.Once);
    }

    [Test]
    public void DeleteAsset_NotFound_ThrowsInvalidOperationException()
    {
        _repoMock.Setup(r => r.GetByIdAsync(5)).ReturnsAsync((Asset?)null);

        Assert.ThrowsAsync<InvalidOperationException>(() => _service.DeleteAsset(5));
    }

    // ── GetAll / GetByCategory / GetByStatus ─────────────────────────────

    [Test]
    public async Task GetAll_ReturnsAllAssets()
    {
        var assets = new List<Asset> { new Asset { Id = 1 }, new Asset { Id = 2 } };
        _repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(assets);

        var result = await _service.GetAll();

        Assert.That(result.Count(), Is.EqualTo(2));
    }

    [Test]
    public async Task GetByCategory_ReturnsCategoryAssets()
    {
        var assets = new List<Asset> { new Asset { Id = 1, CategoryId = 3 } };
        _repoMock.Setup(r => r.GetByCategoryIdAsync(3)).ReturnsAsync(assets);

        var result = await _service.GetByCategory(3);

        Assert.That(result.All(a => a.CategoryId == 3));
    }

    [Test]
    public async Task GetByStatus_ReturnsMatchingAssets()
    {
        var assets = new List<Asset> { new Asset { Id = 1, Status = "Available" } };
        _repoMock.Setup(r => r.GetByStatusAsync("Available")).ReturnsAsync(assets);

        var result = await _service.GetByStatus("Available");

        Assert.That(result.First().Status, Is.EqualTo("Available"));
    }
}