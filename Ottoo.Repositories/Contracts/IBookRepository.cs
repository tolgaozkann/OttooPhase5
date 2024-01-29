using Ottoo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Repositories.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetOneBookByIdAsync(int id);
        void CreateOneBook(Book book);
        void UpdateOneBook(Book book);
        void DeleteOneBook(Book book);
    }
}
