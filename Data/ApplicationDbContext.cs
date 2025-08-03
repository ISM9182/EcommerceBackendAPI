using Microsoft.EntityFrameworkCore;
using EcommerceBackendAPI.Models; 

namespace EcommerceBackendAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<Product> Products { get; set; }
        
    }
}