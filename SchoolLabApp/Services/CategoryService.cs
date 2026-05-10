using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategory(string categoryName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    throw new ArgumentException("Name is required");
                }

                Category category = new Category()
                {
                    Name = categoryName
                };

                await _categoryRepository.AddAsync(category);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task UpdateCategory(Category category)
        {
            try
            {
                var categories = await _categoryRepository.GetByIdAsync(category.Id);

                if (categories == null)
                {
                    throw new Exception("Category not found");
                }

                await _categoryRepository.UpdateAsync(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task DeleteCategory(int id)
        {
            try
            {
                var categories = await _categoryRepository.GetByIdAsync(id);

                if (categories == null)
                {
                    throw new Exception("Category not found");
                }

                await _categoryRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
