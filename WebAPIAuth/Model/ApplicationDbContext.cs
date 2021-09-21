using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPIAuth.Authentication;

namespace WebAPIAuth.Model
{
    //public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
