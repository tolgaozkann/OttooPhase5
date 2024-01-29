using Ottoo.Entities.Dtos.Book;
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
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager _manager;

        public BookManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task<BookDto> CreateOneBookAsync(InsertBookDto book)
        {
            var category = await _manager.Category.GetOneCategoryByCategoryIdAsync(book.CategoryId);

            if (category is null)
                throw new Exception("categoey is not found");

            var entity = new Book
            { CategoryId = book.CategoryId,
              Price = book.Price,
              Title = book.Title
            };

            _manager.Book.Create(entity);
            await _manager.SaveAsync();
            return new BookDto { Title = entity.Title, CategoryId = entity.CategoryId,Price = entity.Price, Id = entity.Id };
        }

        public async Task DeleteOneBookAsync(int id)
        {
            var entity = await GetByIdAndCheck(id);

            _manager.Book.DeleteOneBook(entity);
            await _manager.SaveAsync();
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var books = await _manager.Book.GetAllBooksAsync();

            return books;
        }

        public async Task<BookDto> GetOneBookByIdAsync(int id)
        {
            var entity = await GetByIdAndCheck(id);

            return new BookDto { Title = entity.Title, CategoryId = entity.CategoryId, Price = entity.Price, Id = entity.Id };
        }

        public async Task UpdateOneBookAsync(int id, UpdateBookDto bookDto)
        {
            //check params
            if (bookDto is null)
                throw new ArgumentNullException(nameof(bookDto));

            //check entity
            var entity = await GetByIdAndCheck(id);

            entity.Title = bookDto.Title;
            entity.Price = bookDto.Price;
            entity.Id = bookDto.Id;
            entity.CategoryId = entity.CategoryId;


            _manager.Book.UpdateOneBook(entity);
            await _manager.SaveAsync();

        }

        public async Task<Book> GetByIdAndCheck(int id)
        {
            var entity = await _manager.Book.GetOneBookByIdAsync(id);

            if (entity is null)
                throw new Exception();

            return entity;
        }
    }
}
