using mentoria_api.Models;
using Microsoft.EntityFrameworkCore;

namespace mentoria_api.Repository
{
    public class BookStoreRepository : IBookStoreRepository
    {   
        protected readonly BookStoreContext _context;
        public BookStoreRepository(BookStoreContext context)
        {
            _context = context;
        }
        public IEnumerable<AuthorDTO> GetAuthors()
        {
            var teste = _context.Authors
                .Select(x => new AuthorDTO{
                    AuthorId = x.AuthorId,
                    Name = x.Name,
                    Books = x.Books.Select(b => new BookDTO {
                        Title = b.Title,
                        ReleaseYear = b.ReleaseYear
                    }).ToList()
                });
            return teste;
                    //.Include(e => e.Books)
        }
        public AuthorDTO GetAuthorById(int authorId)
        {
            return _context.Authors.Where(author => author.AuthorId == authorId)
                .Select(x => new AuthorDTO{
                    AuthorId = x.AuthorId,
                    Name = x.Name,
                    Books = x.Books.Select(b => new BookDTO {
                        Title = b.Title,
                        ReleaseYear = b.ReleaseYear
                    }).ToList()
                }).First();
        }
        public AuthorDTOName AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return new AuthorDTOName { AuthorId = author.AuthorId, Name = author.Name };
        }

        public AuthorDTOName UpdateAuthor(Author author, int authorId)
        {
            var myauthor = _context.Authors.Find(authorId);
            if (myauthor != null)
            {
                myauthor.Name = author.Name;
                _context.SaveChanges();
            }
            return new AuthorDTOName { AuthorId = myauthor.AuthorId, Name = author.Name };
        }

        public void DeleteAuthor(int authorId)
        {
            var author = _context.Authors.Find(authorId);
            if(author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }

         public IEnumerable<BookDTOAuthor> GetBooks()
        {
            return _context.Books
                .Select(x => new BookDTOAuthor{
                    BookId = x.BookId,
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    AuthorName = x.Author.Name
                });
        }
        public BookDTOAuthor GetBookById(int bookId)
        {
            return _context.Books
                .Where(b => b.BookId == bookId)
                .Select(x => new BookDTOAuthor{
                    BookId = x.BookId,
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    AuthorName = x.Author.Name
                }).First();
        }
        public BookDTOAuthor AddBook(BookInsert book)
        {
            var newBook = new Book{ Title=book.Title, ReleaseYear = book.ReleaseYear, AuthorId=book.AuthorId };
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return _context.Books
                .Where(b => b.BookId == newBook.BookId)
                .Select(x => new BookDTOAuthor{
                    BookId = x.BookId,
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    AuthorName = x.Author.Name
                }).First();
        }

        public BookDTOAuthor UpdateBook(BookInsert book, int bookId)
        {
            var mybook = _context.Books.Find(bookId);
            if (mybook != null)
            {
                mybook.Title = book.Title;
                mybook.ReleaseYear = book.ReleaseYear;
                mybook.AuthorId = book.AuthorId;
                _context.SaveChanges();
            }
            return _context.Books
                .Where(b => b.BookId == bookId)
                .Select(x => new BookDTOAuthor{
                    BookId = x.BookId,
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    AuthorName = x.Author.Name
                }).First();
        }

        public void DeleteBook(int bookId)
        {
            var book = _context.Books.Find(bookId);
            if(book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
