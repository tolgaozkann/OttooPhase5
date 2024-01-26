using Ottoo.Entities.Dtos.Category;
using Ottoo.Entities.Models;
using Ottoo.Repositories.Contracts;
using Ottoo.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CategoryManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<CategoryDto> CreateOneCategory(InsertCategoryDto category)
        {
            var entity = new Category
            {
                CategoryName = category.CategoryName
            };

            _repositoryManager.Category.CreateOneCategory(entity);

            await _repositoryManager.SaveAsync();

            return new CategoryDto { CategoryName = category.CategoryName };

        }

        public async Task DeleteOneCategoryAsync(int id)
        {
            var entity = await _repositoryManager.Category.GetOneCategoryByCategoryIdAsync(id);

            if (entity is null)
                throw new Exception();

            _repositoryManager.Category.DeleteOneCategory(entity);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var categories = await _repositoryManager.Category.GetAllCategoriesAsync();

            return categories;
        }

        public async Task<CategoryDto> GetOneCategoryByIdAsync(int id)
        {
            var entity = await _repositoryManager.Category.GetOneCategoryByCategoryIdAsync(id);

            if (entity is null)
                throw new Exception();

            return new CategoryDto { CategoryName= entity.CategoryName ,Id = entity.Id};
        }

        public async Task UpdateOneCategoryAsync(int id, UpdateCategoryDto category)
        {
            if (category is null)
                throw new ArgumentNullException(nameof(category));

            var entity = await _repositoryManager.Category.GetOneCategoryByCategoryIdAsync(id);

            if (entity is null)
                throw new Exception();

            _repositoryManager.Category.UpdateOneCategory(entity);
            await _repositoryManager.SaveAsync();
        }
    }
}
