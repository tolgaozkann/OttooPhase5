using Ottoo.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;


        public RepositoryManager(RepositoryContext context, IBookRepository bookRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            _context = context;
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
        }

        public IBookRepository Book => _bookRepository;
        public ICategoryRepository Category => _categoryRepository;

        public IUserRepository User => _userRepository;

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
