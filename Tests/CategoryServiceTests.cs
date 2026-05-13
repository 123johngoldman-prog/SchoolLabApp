
using Moq;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;

[TestFixture]
public class CategoryServiceTests
{
    private Mock<CategoryRepository> _repoMock;
    private CategoryService _service;

    [SetUp]
    public void SetUp()
    {
        _repoMock = new Mock<CategoryRepository>(MockBehavior.Strict, null!);
        _service = new CategoryService(_repoMock.Object);
    }

    // ── AddCategory ──────────────────────────────────────────────────────

    [Test]
    public async Task AddCategory_ValidName_CallsAddAsync()
    {
        _repoMock.Setup(r => r.AddAsync(It.IsAny<Category>())).Returns(Task.CompletedTask);

        // CategoryService swallows ArgumentException internally — it still calls AddAsync
        await _service.AddCategory("Electronics");

        _repoMock.Verify(r => r.AddAsync(It.Is<Category>(c => c.Name == "Electronics")), Times.Once);
    }

    [Test]
    public async Task AddCategory_EmptyName_DoesNotCallAddAsync()
    {
        // The service catches the ArgumentException and logs it — AddAsync should NOT be called
        await _service.AddCategory("   ");

        _repoMock.Verify(r => r.AddAsync(It.IsAny<Category>()), Times.Never);
    }

    // ── UpdateCategory ───────────────────────────────────────────────────

    [Test]
    public async Task UpdateCategory_ExistingCategory_CallsUpdateAsync()
    {
        var cat = new Category { Id = 1, Name = "Updated" };
        _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(cat);
        _repoMock.Setup(r => r.UpdateAsync(cat)).Returns(Task.CompletedTask);

        await _service.UpdateCategory(cat);

        _repoMock.Verify(r => r.UpdateAsync(cat), Times.Once);
    }

    [Test]
    public async Task UpdateCategory_NotFound_DoesNotCallUpdateAsync()
    {
        var cat = new Category { Id = 99 };
        _repoMock.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Category?)null);

        await _service.UpdateCategory(cat);

        _repoMock.Verify(r => r.UpdateAsync(It.IsAny<Category>()), Times.Never);
    }

    // ── DeleteCategory ───────────────────────────────────────────────────

    [Test]
    public async Task DeleteCategory_ExistingId_CallsDeleteAsync()
    {
        _repoMock.Setup(r => r.GetByIdAsync(2)).ReturnsAsync(new Category { Id = 2 });
        _repoMock.Setup(r => r.DeleteAsync(2)).Returns(Task.CompletedTask);

        await _service.DeleteCategory(2);

        _repoMock.Verify(r => r.DeleteAsync(2), Times.Once);
    }

    [Test]
    public async Task DeleteCategory_NotFound_DoesNotCallDeleteAsync()
    {
        _repoMock.Setup(r => r.GetByIdAsync(50)).ReturnsAsync((Category?)null);

        await _service.DeleteCategory(50);

        _repoMock.Verify(r => r.DeleteAsync(It.IsAny<int>()), Times.Never);
    }

    // ── GetAll ───────────────────────────────────────────────────────────

    [Test]
    public async Task GetAll_ReturnsAllCategories()
    {
        var cats = new List<Category> { new Category { Id = 1 }, new Category { Id = 2 } };
        _repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(cats);

        var result = await _service.GetAll();

        Assert.That(result.Count(), Is.EqualTo(2));
    }
}
