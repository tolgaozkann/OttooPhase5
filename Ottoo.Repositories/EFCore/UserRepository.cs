using Microsoft.EntityFrameworkCore;
using Ottoo.Entities.Models;
using Ottoo.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Repositories.EFCore
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneUser(User user) => Create(user);

        public void DeleteOneUser(User user) => Delete(user);

        public async Task<List<User>> GetAllUsersAsync() => 
            await FindAll()
            .OrderBy(u => u.Id)
            .ToListAsync();

        public async Task<User> GetOneUserByUserIdAsync(int userId) => 
            await FindByCondition(u => u.Id.Equals(userId))
            .SingleOrDefaultAsync();

        public void UpdateOneUser(User userId) => Update(userId);
    }
}
