using BooksAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.DBContext
{
    public class BookDBContext:DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> op):base(op)
        {

        }

        public DbSet<Book> Books { get; set; }
        //Not added Authors because only saving Author not making sense but it will create the Table as There Is entity Author Present in Book so . indirectly linked with this DBContext
    }
}
