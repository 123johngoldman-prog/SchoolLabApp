using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Data;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories.Implementations
{
    public class AssetRepository:IAssetRepository<Asset>
    {
        private readonly SchoolLabAppDbContext _context;

        public AssetRepository(SchoolLabAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Asset asset)
        {
            await _context.Assets.AddAsync(asset);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Asset asset)
        {
            _context.Assets.Update(asset);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var asset = await _context.Assets.FindAsync(id);
            if (asset != null)
            {
                _context.Assets.Remove(asset);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Asset>> GetAllAsync()
        {
            return await _context.Assets
                .Include(a => a.Category)
                .Include(a => a.Loans)
                .Include(a => a.Damages)
                .ToListAsync();
        }

        public async Task<IEnumerable<Asset>> GetByCategoryIdAsync(int categoryId)
        {
            return await _context.Assets
                .Where(a => a.CategoryId == categoryId)
                .Include(a => a.Category)
                .ToListAsync();
        }

        public async Task<Asset?> GetByIdAsync(int id)
        {
            return await _context.Assets
                .Include(a => a.Category)
                .Include(a => a.Loans)
                .Include(a => a.Damages)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Asset?> GetByInventoryNumberAsync(string inventoryNumber)
        {
            return await _context.Assets
                .Include(a => a.Category)
                .Include(a => a.Loans)
                .Include(a => a.Damages)
                .FirstOrDefaultAsync(a => a.InventoryNumber == inventoryNumber);
        }

        public async Task<IEnumerable<Asset>> GetByStatusAsync(string status)
        {
            return await _context.Assets
                .Where(a => a.Status == status)
                .Include(a => a.Category)
                .ToListAsync();
        }

    }
}
