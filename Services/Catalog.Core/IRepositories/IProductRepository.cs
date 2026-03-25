using Catalog.Core.Entities;

namespace Catalog.Core.IRepositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> GetProductById(string id);

    Task<IEnumerable<Product>> GetProductsByName(string name);

    Task<IEnumerable<Product>> GetProductsByBrand(string brand);
    Task<IEnumerable<Product>> GetProductsByBrandId(string brandId);

    Task<IEnumerable<Product>> GetProductsByTypeId(string typeId);
    Task<IEnumerable<Product>> GetProductsByType(string type);

    Task<bool> UpdateProduct(Product product);
    Task<bool> DeleteProduct(string id);
    Task<bool> DeleteProduct(Product product);
}
