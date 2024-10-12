using Microsoft.EntityFrameworkCore;

namespace Helpy_Web_Apis.Models
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        public DbSet<LoginWithEmail> LoginWithEmails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Additional configurations can be added here, for example:
            // modelBuilder.Entity<LoginWithEmail>().HasIndex(l => l.Email).IsUnique();
        }
    }
}
