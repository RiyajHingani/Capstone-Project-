using HealthCare.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthCare.Data
{
    public class HealthcareContext :IdentityDbContext<AppUser>

    {
        public HealthcareContext(DbContextOptions<HealthcareContext> options) : base(options)
        {

        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
