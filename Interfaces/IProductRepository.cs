// Local: EcommerceBackendAPI/Interfaces/IProductRepository.cs

using EcommerceBackendAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceBackendAPI.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        // Alterado o tipo de retorno para Task<Product?>
        Task<Product?> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}