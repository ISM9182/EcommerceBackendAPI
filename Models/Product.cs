// Local: EcommerceBackendAPI/Models/Product.cs

namespace EcommerceBackendAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; } // Adicionado 'required'
        public required string Description { get; set; } // Adicionado 'required'
        public required decimal Price { get; set; } // Adicionado 'required'
    }
}