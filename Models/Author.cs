namespace mentoria_api.Models{
    using System.ComponentModel.DataAnnotations;
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<Book>? Books { get; set; } = null!;
    }

    public class AuthorDTO
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<BookDTO>? Books { get; set; } = null!;
    }

    public class AuthorDTOName
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }

}
