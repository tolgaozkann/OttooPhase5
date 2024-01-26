using Ottoo.Entities.Dtos.User;
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
    public class UserManager : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UserManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<UserDto> CreateOneUserAsync(UserRegisterDto userRegisterDto)
        {
            if(userRegisterDto is null)
                throw new ArgumentNullException(nameof(userRegisterDto));

            var entity = new User { UserName = userRegisterDto.UserName };

            _repositoryManager.User.Create(entity);
            await _repositoryManager.SaveAsync();

            return new UserDto { UserName = userRegisterDto.UserName, Id = entity.Id };
        }

        public async Task<UserDto> DeleteOneUserAsync(int id)
        {
            var entity = await _repositoryManager.User.GetOneUserByUserIdAsync(id);

            if(entity is null)
                throw new ArgumentNullException(nameof(entity));

            _repositoryManager.User.Delete(entity);
            await _repositoryManager.SaveAsync();
            return new UserDto { UserName= entity.UserName, Id = entity.Id };
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users = await _repositoryManager.User.GetAllUsersAsync();

            return users;
        }

        public async Task<UserDto> GetOneUserByIdAsync(int id)
        {
            var entity = await _repositoryManager.User.GetOneUserByUserIdAsync(id);

            if( entity is null)
                throw new ArgumentNullException(nameof(entity));

            return new UserDto { UserName = entity.UserName, Id = entity.Id };
        }

        public async Task<UserDto> UpdateOneUserAsync(int id, UserDto userDto)
        {
            var entity = await _repositoryManager.User.GetOneUserByUserIdAsync(id);

            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            entity.UserName = userDto.UserName;

            _repositoryManager.User.Update(entity);
            await _repositoryManager.SaveAsync();

            return new UserDto { UserName = entity.UserName, Id = entity.Id };
        }
    }
}
