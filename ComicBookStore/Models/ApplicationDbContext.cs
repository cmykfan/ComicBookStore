using System.Data.Entity;

namespace ComicBookStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products
        {
            get; set;
        }
    }
}
