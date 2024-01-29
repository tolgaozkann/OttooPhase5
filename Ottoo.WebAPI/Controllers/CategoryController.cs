using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ottoo.Entities.Dtos.Category;
using Ottoo.Services.Contracts;

namespace Ottoo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _services;

        public CategoryController(IServiceManager services)
        {
            _services = services;
        }


        [HttpGet(Name = "GetAllCategories")]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            var categories = await _services.CategoryService.GetCategoriesAsync();

            return Ok(categories);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCategoryByIdAsycn([FromRoute] int id)
        {
            var Category = await _services.CategoryService.GetOneCategoryByIdAsync(id);

            return Ok(Category);
        }

        [HttpPost(Name = "CreateOneCategory")]
        public async Task<IActionResult> CreateOneCategoryAsync([FromBody] InsertCategoryDto category)
        {
            var result = await _services.CategoryService.CreateOneCategory(category);

            return StatusCode(201, result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneBookAsync([FromRoute] int id)
        {
            await _services.CategoryService.DeleteOneCategoryAsync(id);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneCategoryAsync([FromRoute] int id, [FromBody] UpdateCategoryDto category)
        {
            if (category is null)
                return BadRequest("Request body is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);
            await _services.CategoryService.UpdateOneCategoryAsync(id, category);

            return NoContent();
        }

    }
}
