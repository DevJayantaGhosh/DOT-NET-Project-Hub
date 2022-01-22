using BooksAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository BookRepository;

        public BookController(IBookRepository _BookRepository)
        {
            this.BookRepository = _BookRepository;

        }
    }
}
