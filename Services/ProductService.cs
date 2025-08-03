// Local: EcommerceBackendAPI/Services/ProductService.cs

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

        // Alterado o tipo de retorno para Task<Product?>
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        // AddProductAsync sempre retorna um produto válido se a operação for bem-sucedida,
        // então o tipo de retorno Task<Product> está correto aqui.
        public async Task<Product> AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            return product;
        }

        // Alterado o tipo de retorno para Task<Product?>
        public async Task<Product?> UpdateProductAsync(int id, Product product)
        {
            // Verifica se o ID do produto no corpo da requisição corresponde ao ID da URL
            if (id != product.Id)
            {
                return null; // Indica BadRequest ou inconsistência
            }

            var existingProduct = await _productRepository.GetByIdAsync(id);
            if (existingProduct == null)
            {
                return null; // Produto não encontrado
            }

            // Atualiza as propriedades do produto existente
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            // Atualize outras propriedades conforme necessário

            await _productRepository.UpdateAsync(existingProduct);
            return existingProduct;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return false; // Produto não encontrado
            }
            await _productRepository.DeleteAsync(id);
            return true;
        }
    }
}