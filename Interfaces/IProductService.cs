// Local: EcommerceBackendAPI/Interfaces/IProductService.cs

using EcommerceBackendAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceBackendAPI.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        // Alterado o tipo de retorno para Task<Product?>
        Task<Product?> GetProductByIdAsync(int id);
        // AddProductAsync não retorna nulo em caso de sucesso, então Task<Product> está correto.
        Task<Product> AddProductAsync(Product product);
        // Alterado o tipo de retorno para Task<Product?>
        Task<Product?> UpdateProductAsync(int id, Product product);
        Task<bool> DeleteProductAsync(int id);
    }
}