using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;

namespace SchoolLabApp.Repositories.Implementations
{
    public class DamageRepository : IDamageRepository
{
    private readonly SchoolLabAppDbContext _context;

    public DamageRepository(SchoolLabAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Damage>> GetAllAsync()
    {
        return await _context.Damages.ToListAsync();
    }

    public async Task<Damage?> GetByIdAsync(int id)
    {
        return await _context.Damages.FindAsync(id);
    }

    public async Task AddAsync(Damage damage)
    {
        await _context.Damages.AddAsync(damage);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Damage damage)
    {
        _context.Damages.Update(damage);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var damage = await _context.Damages.FindAsync(id);
        if (damage != null)
        {
            _context.Damages.Remove(damage);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.Damages.AnyAsync(d => d.Id == id);
    }

    }
}