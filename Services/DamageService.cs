using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories;

namespace SchoolLabApp.Services
{
    public class DamageService : IDamageRepository
    {
        private readonly SchoolLabAppDbContext _context;

        public DamageService(SchoolLabAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Damage>> GetAllAsync()
        {
            return await _context.Damages
                .Include(d => d.Asset)
                .ToListAsync();
        }

        public async Task<Damage?> GetByIdAsync(int id)
        {
            return await _context.Damages
                .Include(d => d.Asset)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task AddAsync(Damage damage)
        {
            if (string.IsNullOrWhiteSpace(damage.Description))
                throw new ArgumentException("Description cannot be empty.");

            damage.DateReported = DateTime.UtcNow;

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