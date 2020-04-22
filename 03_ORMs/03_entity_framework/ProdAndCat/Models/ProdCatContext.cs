using Microsoft.EntityFrameworkCore;
namespace ProdAndCat.Models
{
    public class ProdCatContext : DbContext
    {
        public ProdCatContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Association> Associations { get; set; }

    }
}