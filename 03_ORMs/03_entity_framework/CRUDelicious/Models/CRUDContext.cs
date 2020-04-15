using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Models
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
    }
}