

namespace Ottoo.Services.Contracts
{
    public interface IServiceManager
    {
        public IBookService BookService { get; }
        public ICategoryService CategoryService { get; }
        public IUserService UserService { get; }
    }
}
