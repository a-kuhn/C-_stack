using Microsoft.EntityFrameworkCore;
namespace LoginRegWithDB.Models
{
    public class LoginRegContext : DbContext
    {
        public LoginRegContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}