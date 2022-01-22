using BooksAPI.DBContext;
using BooksAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Services
{
    public class BookRepository : IBookRepository,IDisposable
    {
        private  BookDBContext bookDbContext;

        public BookRepository(BookDBContext bookDbContext)
        {
            this.bookDbContext = bookDbContext;
        }





        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (bookDbContext != null)
                {
                    bookDbContext.Dispose();
                    bookDbContext = null;
                }
            }
        }




        public async Task<Book> GetBookAsync(Guid id)
        {
            return await bookDbContext.Books.Where(b => b.BookID == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await bookDbContext.Books.Include(b => b.Author).ToListAsync();
        }
    }
}
