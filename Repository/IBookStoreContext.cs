using Microsoft.EntityFrameworkCore;
using mentoria_api.Models;

namespace mentoria_api.Repository 
{
    public interface IBookStoreContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public int SaveChanges();
    }
}