using Microsoft.EntityFrameworkCore;
using My_book_store.Data.Model;

namespace My_book_store.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
