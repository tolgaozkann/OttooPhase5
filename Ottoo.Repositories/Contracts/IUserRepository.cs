using Ottoo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Repositories.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetOneUserByUserIdAsync(int userId);
        void CreateOneUser(User user);
        void DeleteOneUser(User user);
        void UpdateOneUser(User user);
    }
}
