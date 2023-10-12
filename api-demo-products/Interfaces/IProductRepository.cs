using api_demo_products.Models;
using Microsoft.EntityFrameworkCore;

namespace api_demo_products.Interfaces
{
    public interface IProductRepository
    {
        int SaveProduct(Product newProduct);
        DbSet<Product>? RetrieveProducts();
        Product? RetrieveProduct(int id);
    }
}
