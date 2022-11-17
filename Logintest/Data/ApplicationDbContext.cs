using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Logintest.Models;
namespace Logintest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public class AppDbContext : DbContext
        {
            public DbSet<Customer> Customer { get; set; }
        }
    }
}