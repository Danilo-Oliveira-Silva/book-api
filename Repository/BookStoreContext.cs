using Microsoft.EntityFrameworkCore;
using mentoria_api.Models;

namespace mentoria_api.Repository;
public class BookStoreContext : DbContext, IBookStoreContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) {}
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = "Server=127.0.0.1;Database=BookStore;User=SA;Password=Trybe@123456";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);
    }
}