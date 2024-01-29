using Ottoo.Entities.Dtos.Category;
using Ottoo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<CategoryDto> GetOneCategoryByIdAsync(int id);
        Task<CategoryDto> CreateOneCategory(InsertCategoryDto category);
        Task UpdateOneCategoryAsync(int id, UpdateCategoryDto category);
        Task DeleteOneCategoryAsync(int id);
    }
}
