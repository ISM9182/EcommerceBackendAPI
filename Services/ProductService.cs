
using EcommerceBackendAPI.Interfaces;
using EcommerceBackendAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceBackendAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            return product;
        }

        public async Task<Product?> UpdateProductAsync(int id, Product product)
        {
            if (id != product.Id)
            {
                return null; 
            }

            var existingProduct = await _productRepository.GetByIdAsync(id);
            if (existingProduct == null)
            {
                return null; 
            }

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;

            await _productRepository.UpdateAsync(existingProduct);
            return existingProduct;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return false; 
            }
            await _productRepository.DeleteAsync(id);
            return true;
        }
    }
}