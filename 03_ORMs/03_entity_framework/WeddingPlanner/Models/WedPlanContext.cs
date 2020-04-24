using Microsoft.EntityFrameworkCore;
namespace WeddingPlanner.Models
{
    public class WedPlanContext : DbContext
    {
        public WedPlanContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }

    }
}