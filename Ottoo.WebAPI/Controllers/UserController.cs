using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ottoo.Entities.Dtos.Category;
using Ottoo.Entities.Dtos.User;
using Ottoo.Services.Contracts;

namespace Ottoo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet(Name ="GetAllUsers")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _serviceManager.UserService.GetAllUsersAsync();

            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneUserByIdAsync([FromRoute] int id)
        {
            var user = await _serviceManager.UserService.GetOneUserByIdAsync(id);

            if(user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost(Name = "CreateOneUser")]
        public async Task<IActionResult> CreateOneUserAsync([FromBody] UserRegisterDto userRegisterDto)
        {
            var result = await _serviceManager.UserService.CreateOneUserAsync(userRegisterDto);

            return StatusCode(201, result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneUserByIdAsync([FromRoute] int id)
        {
            await _serviceManager.UserService.DeleteOneUserAsync(id);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneUserAsync([FromRoute] int id, [FromBody] UserDto user)
        {
            if (user is null)
                return BadRequest("Request body is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);
            await _serviceManager.UserService.UpdateOneUserAsync(id, user);

            return NoContent();
        }
    }
}
