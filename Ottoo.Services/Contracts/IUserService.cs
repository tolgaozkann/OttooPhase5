using Ottoo.Entities.Dtos.User;
using Ottoo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Services.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<UserDto> GetOneUserByIdAsync(int id);
        Task<UserDto> CreateOneUserAsync(UserRegisterDto userRegisterDto);
        Task<UserDto> UpdateOneUserAsync(int id, UserDto userDto);
        Task<UserDto> DeleteOneUserAsync(int id);
    }
}
