using Microsoft.EntityFrameworkCore;
using Ottoo.Entities.Models;
using Ottoo.Repositories.Contracts;

namespace Ottoo.Repositories.EFCore
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneCategory(Category category) => Create(category);

        public void DeleteOneCategory(Category category) => Delete(category);

        public async Task<List<Category>> GetAllCategoriesAsync() =>
            await FindAll()
            .OrderBy(x => x.CategoryName)
            .ToListAsync();

        public async Task<Category> GetOneCategoryByCategoryIdAsync(int categoryId) =>
            await FindByCondition(c => c.Id.Equals(categoryId))
            .SingleOrDefaultAsync();

        public void UpdateOneCategory(Category category) => Update(category);
    }
}
