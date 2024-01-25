using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IBookRepository BookRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IUserRepository UserRepository { get; }
        Task SaveAsync();
    }
}
