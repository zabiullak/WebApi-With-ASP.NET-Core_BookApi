using BookAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class BooksRepository : IBookRepository
    {

        private readonly List<Book> books = new()
        {
            new Book { Id = 1, Title = "Attitude is Everithing", Author = "Jeff Kellar", Prize = 150, Date = DateTimeOffset.UtcNow, Discription = "Self improvement Book" },
            new Book { Id = 2, Title = "The Morning micarle", Author = "Hal Heldrod", Prize = 200, Date = DateTimeOffset.UtcNow, Discription = "amazingness of wakeup early" },
            new Book { Id = 3, Title = "The C# by Micro", Author = "MS", Prize = 997, Date = DateTimeOffset.UtcNow, Discription = "this is fake Book" }
        };

        public async Task<Book> Create(Book book)
        {
            books.Add(book);
            await Task.CompletedTask;
            return book;
        }

        public async Task Delete(int id)
        {
            var index = books.FindIndex(existingBook => existingBook.Id == id);
            books.RemoveAt(index);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Book>> Get()
        {
            return await Task.FromResult(books);
        }

        public async Task<Book> Get(int id)
        {
            var book = books.Where(book => book.Id == id).SingleOrDefault();
            return await Task.FromResult(book);
        }

        public async Task Update(Book book)
        {
            var index = books.FindIndex(existingItems => existingItems.Id == book.Id);
            books[index] = book;
            await Task.CompletedTask;
        }

    }
}
