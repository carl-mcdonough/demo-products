﻿using api_demo_products.Data;
using api_demo_products.Interfaces;
using api_demo_products.Models;
using Microsoft.EntityFrameworkCore;

namespace api_demo_products.Repository
{
    public class ProductsRepository : IProductRepository
    {
        private readonly ILogger<ProductsRepository> _logger;
        readonly ProductContext _productContext;

        public ProductsRepository(ProductContext context, ILogger<ProductsRepository> logger)
        {
            _logger = logger;
            _productContext = context;
        }

        public int SaveProduct(Product newProduct)
        {
            _productContext.Add(newProduct);

            if (_productContext.SaveChanges() > 0)
                return newProduct.Id;

            return 0;
        }

        public DbSet<Product>? RetrieveProducts()
        {
            return _productContext.Products;
        }
    }
}