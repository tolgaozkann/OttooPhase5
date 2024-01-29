using Ottoo.Entities.Dtos.Book;
using Ottoo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Services.Contracts
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<BookDto> GetOneBookByIdAsync(int id);
        Task<BookDto> CreateOneBookAsync(InsertBookDto book);
        Task UpdateOneBookAsync(int id, UpdateBookDto bookDto);
        Task DeleteOneBookAsync(int id);
    }
}
