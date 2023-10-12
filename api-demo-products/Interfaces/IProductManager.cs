using api_demo_products.Models;

namespace api_demo_products.Interfaces
{
    public interface IProductManager
    {
        Product? AddProduct(ProductRequest request);
        List<Product>? GetProducts();
        List<Product>? GetProducts(int count);
        Product? GetProduct(int id);
    }
}