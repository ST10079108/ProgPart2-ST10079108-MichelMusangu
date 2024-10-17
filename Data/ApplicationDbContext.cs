using ClaimsPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClaimsPortal.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Claim> Claims { get; set; }

    }
}
