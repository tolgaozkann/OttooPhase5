using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ottoo.Entities.Dtos.Book;
using Ottoo.Services.Contracts;
using System.Text.Json;

namespace Ottoo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BookController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet(Name = "GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = await _manager.BookService.GetAllBooksAsync();

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneBook([FromRoute(Name = "id")] int id)
        {
            return Ok(await _manager.BookService.GetOneBookByIdAsync(id));
        }

        [HttpPost(Name = "CreateOneBook")]
        public async Task<IActionResult> CreateOneBook([FromBody] InsertBookDto bookDto)
        {
            var book = await _manager.BookService.CreateOneBookAsync(bookDto);
            return StatusCode(201, book);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] UpdateBookDto book)
        {
            if (book is null)
                return BadRequest("Request body is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _manager.BookService.UpdateOneBookAsync(id, book);

            return NoContent();//204
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneBook([FromRoute(Name = "id")] int id)
        {
            await _manager.BookService.DeleteOneBookAsync(id);
            return NoContent();
        }


    }
}
