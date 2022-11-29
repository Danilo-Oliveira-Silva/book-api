namespace mentoria_api.Models{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear  { get; set; }
        public int AuthorId { get; set; } 
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        
    }

    public class BookDTO
    {
        public string Title { get; set; }
        public int ReleaseYear  { get; set; }
    }

    public class BookDTOAuthor
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear  { get; set; }
        public string AuthorName { get; set; }

    }

    public class BookInsert
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear  { get; set; }
        public int AuthorId { get; set; } 
    }
}
