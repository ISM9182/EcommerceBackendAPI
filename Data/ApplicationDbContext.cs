// Crie este arquivo em: EcommerceBackendAPI/Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using EcommerceBackendAPI.Models; // Certifique-se de que o namespace da sua entidade está aqui

namespace EcommerceBackendAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Crie uma propriedade DbSet para cada entidade que você deseja gerenciar
        public DbSet<Product> Products { get; set; }
        // Se você adicionar outras entidades, crie um DbSet para elas também
    }
}