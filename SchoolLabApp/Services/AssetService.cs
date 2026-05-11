using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class AssetService
    {
        private readonly AssetRepository _assetRepository;

        public AssetService(AssetRepository assetRepository)
            => _assetRepository = assetRepository;

        public async Task AddAssets(string name, string status, int categoryId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Asset name is required.");

            var asset = new Asset
            {
                Name        = name,
                Status      = status,
                CategoryId  = categoryId,
                CreatedDate = DateTime.Now
            };
            await _assetRepository.AddAsync(asset);
        }

        public async Task UpdateAsset(Asset asset)
        {
            if (await _assetRepository.GetByIdAsync(asset.Id) == null)
                throw new InvalidOperationException("Asset not found.");
            await _assetRepository.UpdateAsync(asset);
        }

        public async Task DeleteAsset(int id)
        {
            if (await _assetRepository.GetByIdAsync(id) == null)
                throw new InvalidOperationException("Asset not found.");
            await _assetRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Asset>> GetAll()
            => await _assetRepository.GetAllAsync();

        public async Task<IEnumerable<Asset>> GetByCategory(int categoryId)
            => await _assetRepository.GetByCategoryIdAsync(categoryId);

        public async Task<IEnumerable<Asset>> GetByStatus(string status)
            => await _assetRepository.GetByStatusAsync(status);
    }
}
