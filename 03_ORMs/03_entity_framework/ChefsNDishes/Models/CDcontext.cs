using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Models
{
    public class CDcontext : DbContext
    {
        public CDcontext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Chef> Chefs { get; set; }
    }
}