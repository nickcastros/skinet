using System;
using skinet.Core.Entities;

namespace skinet.Core.Interfaces;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetProductsAsync(string? brands, string? types, string? sort);
    Task<Product?> GetProductByIdAsync(int id);
    Task<IReadOnlyList<string>> GetProductBrandsAsync();
    Task<IReadOnlyList<string>> GetProductTypesAsync();
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
    bool ProductExists(int id);
    Task<bool> SaveChangesAsync();

}
