using mentoria_api.Models;

namespace mentoria_api.Repository
{
    public interface IBookStoreRepository
    {
        IEnumerable<BookDTOAuthor> GetBooks();
        BookDTOAuthor GetBookById(int bookId);
        BookDTOAuthor AddBook(BookInsert book);
        BookDTOAuthor UpdateBook(BookInsert book, int bookId);
        void DeleteBook(int id);
        IEnumerable<AuthorDTO> GetAuthors();
        AuthorDTO GetAuthorById(int authorId);
        AuthorDTOName AddAuthor(Author author);
        AuthorDTOName UpdateAuthor(Author author, int authorId);
        void DeleteAuthor(int authorId);
    }
}