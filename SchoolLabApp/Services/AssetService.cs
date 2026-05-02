using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Services
{
    public class AssetService
    {
        private readonly AssetRepository _assetRepository;

        public AssetService(AssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public async Task AddAssets(string name,string status, int categoryId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name is required");
                }

                Asset asset = new Asset()
                {
                    Name = name,
                    Status = status,
                    CategoryId = categoryId,
                    CreatedDate = DateTime.Now,
                };

                await _assetRepository.AddAsync(asset);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task UpdateAsset(Asset asset)
        {
            try
            {
                var assets = await _assetRepository.GetByIdAsync(asset.Id);

                if (assets == null)
                {
                    throw new Exception("Asset not found");
                }

                await _assetRepository.UpdateAsync(asset);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeleteAsset(int id)
        {
            try
            {
                var asset = await _assetRepository.GetByIdAsync(id);

                if (asset == null)
                {
                    throw new Exception("Asset not found");
                }

                await _assetRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public async Task<IEnumerable<Asset>> GetStatus(string status)
        {
            return await _assetRepository.GetByStatusAsync(status);
        }
        public async Task<IEnumerable<Asset>> GetAll()
        {
            return await _assetRepository.GetAllAsync();
        }
    }
}
