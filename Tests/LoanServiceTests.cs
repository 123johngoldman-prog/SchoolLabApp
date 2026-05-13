
using Moq;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Services;

[TestFixture]
public class LoanServiceTests
{
    private Mock<LoanRepository> _repoMock;
    private LoanService _service;

    [SetUp]
    public void SetUp()
    {
        _repoMock = new Mock<LoanRepository>(MockBehavior.Strict, null!);
        _service = new LoanService(_repoMock.Object);
    }

    // ── AddLoan ──────────────────────────────────────────────────────────

    [Test]
    public async Task AddLoan_ValidInput_CallsAddAsync()
    {
        _repoMock.Setup(r => r.AddAsync(It.IsAny<Loan>())).Returns(Task.CompletedTask);

        await _service.AddLoan(1, 2, "Active");

        _repoMock.Verify(r => r.AddAsync(It.Is<Loan>(l =>
            l.AssetId == 1 && l.PersonId == 2 && l.Status == "Active")), Times.Once);
    }

    // ── ReturnLoan ───────────────────────────────────────────────────────

    [Test]
    public async Task ReturnLoan_ExistingLoan_SetsStatusAndDate()
    {
        var loan = new Loan { Id = 1, Status = "Active" };
        _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(loan);
        _repoMock.Setup(r => r.UpdateAsync(It.IsAny<Loan>())).Returns(Task.CompletedTask);

        await _service.ReturnLoan(1);

        Assert.That(loan.Status, Is.EqualTo("Returned"));
        Assert.That(loan.ReturnedDate, Is.Not.Null);
    }

    [Test]
    public void ReturnLoan_NotFound_ThrowsInvalidOperationException()
    {
        _repoMock.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Loan?)null);

        Assert.ThrowsAsync<InvalidOperationException>(() => _service.ReturnLoan(99));
    }

    // ── UpdateLoan ───────────────────────────────────────────────────────

    [Test]
    public async Task UpdateLoan_ExistingLoan_CallsUpdateAsync()
    {
        var loan = new Loan { Id = 1, Status = "Active" };
        _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(loan);
        _repoMock.Setup(r => r.UpdateAsync(loan)).Returns(Task.CompletedTask);

        await _service.UpdateLoan(loan);

        _repoMock.Verify(r => r.UpdateAsync(loan), Times.Once);
    }

    [Test]
    public void UpdateLoan_NotFound_ThrowsInvalidOperationException()
    {
        var loan = new Loan { Id = 77 };
        _repoMock.Setup(r => r.GetByIdAsync(77)).ReturnsAsync((Loan?)null);

        Assert.ThrowsAsync<InvalidOperationException>(() => _service.UpdateLoan(loan));
    }

    // ── DeleteLoan ───────────────────────────────────────────────────────

    [Test]
    public async Task DeleteLoan_ExistingId_CallsDeleteAsync()
    {
        _repoMock.Setup(r => r.GetByIdAsync(3)).ReturnsAsync(new Loan { Id = 3 });
        _repoMock.Setup(r => r.DeleteAsync(3)).Returns(Task.CompletedTask);

        await _service.DeleteLoan(3);

        _repoMock.Verify(r => r.DeleteAsync(3), Times.Once);
    }

    [Test]
    public void DeleteLoan_NotFound_ThrowsInvalidOperationException()
    {
        _repoMock.Setup(r => r.GetByIdAsync(10)).ReturnsAsync((Loan?)null);

        Assert.ThrowsAsync<InvalidOperationException>(() => _service.DeleteLoan(10));
    }

    // ── GetAll / GetLoansByPerson ─────────────────────────────────────────

    [Test]
    public async Task GetAll_ReturnsAllLoans()
    {
        _repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<Loan> { new Loan(), new Loan() });

        var result = await _service.GetAll();

        Assert.That(result.Count(), Is.EqualTo(2));
    }

    [Test]
    public async Task GetLoansByPerson_ReturnsPersonLoans()
    {
        var loans = new List<Loan> { new Loan { PersonId = 5 } };
        _repoMock.Setup(r => r.GetByPersonIdAsync(5)).ReturnsAsync(loans);

        var result = await _service.GetLoansByPerson(5);

        Assert.That(result.All(l => l.PersonId == 5));
    }
}