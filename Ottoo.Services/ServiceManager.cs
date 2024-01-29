using Ottoo.Entities.Dtos.User;
using Ottoo.Entities.Models;
using Ottoo.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public ServiceManager(IUserService userService, IBookService bookService, ICategoryService categoryService)
        {
            _userService = userService;
            _bookService = bookService;
            _categoryService = categoryService;
        }

        public IBookService BookService => _bookService;

        public ICategoryService CategoryService => _categoryService;

        public IUserService UserService => _userService;

        
    }
}
