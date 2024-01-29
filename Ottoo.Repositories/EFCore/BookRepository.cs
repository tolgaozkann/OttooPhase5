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
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneBook(Book book) =>
            Create(book);

        public void DeleteOneBook(Book book) =>
            Delete(book);

        public async Task<List<Book>> GetAllBooksAsync() =>
            await FindAll()
                .OrderBy(b => b.Id)
                .ToListAsync();

        public async Task<Book> GetOneBookByIdAsync(int id) =>
            await FindByCondition(item => item.CategoryId.Equals(id))
            .SingleOrDefaultAsync();

        public void UpdateOneBook(Book book) => Update(book);
    }
}
