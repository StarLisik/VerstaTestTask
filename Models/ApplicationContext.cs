using Microsoft.EntityFrameworkCore;

namespace ASPTest.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
