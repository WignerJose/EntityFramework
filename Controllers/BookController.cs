using EntityFramework.DbContexts;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFramework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookContext _dbContext;
        private readonly ILogger<BookController> _logger;

        public BookController(BookContext dbContext, ILogger<BookController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet("v1/books", Name = "GetBooks")]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            var books = await _dbContext.Book.Where(s => s.BookId > 0).ToListAsync();
            return Ok(books);
        }

        [HttpGet("v1/book/prices", Name = "GetPricies")]
        public async Task<ActionResult<List<object>>> GetPricies()
        {
            var books = await _dbContext.Book.Select(book => new { bookTitle = book.Title, Precie = book.PreciePromotion }).ToListAsync();
            return Ok(books);
        }

        [HttpGet("v1/book/comments", Name = "GetComments")]
        public async Task<ActionResult<List<object>>> GetComments()
        {
            var books = await _dbContext.Book.Select(book => new
            {
                BookIdentity = book.BookId,
                bookTitle = book.Title,
                comments = book.Comments.Select(comment=>comment.Commentary).ToList()
            }).ToListAsync();
            return Ok(books);
        }
        [HttpGet("v1/book/authors", Name = "GetAuthors")]
        public async Task<ActionResult<List<object>>> GetAuthors()
        {
            var books = await _dbContext.Book.Select(book => new
            {
                BookIdentity = book.BookId,
                bookTitle = book.Title,
                Authors = book.Authors.Select(author => author.Author.UserName).ToList()
            }).ToListAsync();
            return Ok(books);
        }
    }
}