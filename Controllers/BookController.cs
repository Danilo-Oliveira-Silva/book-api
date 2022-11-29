using Microsoft.AspNetCore.Mvc;
using mentoria_api.Repository;
using mentoria_api.Models;

namespace mentoria_api.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookStoreController : Controller 
    {
        private readonly IBookStoreRepository _repository;
        public BookStoreController(IBookStoreRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("view")]
        public IActionResult BookView()
        {
            ViewData["Title"] = "Books";
            IList<BookDTOAuthor> booksList = _repository.GetBooks().ToList();
            ViewBag.books = booksList;
            return View();
        }


        [HttpGet("view/create")]
        public IActionResult FormView()
        {
            ViewData["Title"] = "Book - Create";
            return View();
        }


        [HttpGet("{bookId}")]
        public IActionResult GetBookById(int bookId)
        {
            return Ok(_repository.GetBookById(bookId));
        }
      
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_repository.GetBooks());
        }

        [HttpPost]
        public IActionResult Add([FromBody] BookInsert book)
        {
            return Created("",_repository.AddBook(book));
        }

        [HttpPut("{bookId}")]
        public IActionResult Update([FromBody] BookInsert book, int bookId)
        {
            return Ok(_repository.UpdateBook(book, bookId));
        }

        [HttpDelete("{bookId}")]
        public IActionResult Delete(int bookId)
        {
            _repository.DeleteBook(bookId);
            return Ok(new { message= "Removido com sucesso"});
        }
   
    }

    [Route("authors")]
    public class AuthorController : Controller 
    {
        private readonly IBookStoreRepository _repository;
        public AuthorController(IBookStoreRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{authorId}")]
        public IActionResult GetAuthorById(int authorId)
        {
            return Ok(_repository.GetAuthorById(authorId));
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            return Ok(_repository.GetAuthors());
        }

        [HttpPost]
        public IActionResult Add([FromBody] Author author)
        {
            return Created("",_repository.AddAuthor(author));
        }

        [HttpPut("{authorId}")]
        public IActionResult Update([FromBody] Author author, int authorId)
        {
            return Ok(_repository.UpdateAuthor(author, authorId));
        }

        [HttpDelete("{authorId}")]
        public IActionResult Delete(int authorId)
        {
            _repository.DeleteAuthor(authorId);
            return Ok(new { message= "Removido com sucesso"});
        }
    }
}