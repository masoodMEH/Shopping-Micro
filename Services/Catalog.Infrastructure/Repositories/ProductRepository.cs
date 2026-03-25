using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Repositories;

public class ProductRepository(ICatalogContext context) : IProductRepository
{
    private readonly ICatalogContext _context = context;

    public Task<bool> DeleteProduct(string id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _context.Products.Find(x => true).ToListAsync();
    }

    public async Task<Product> GetProductById(string id)
    {
        return await _context.Products.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public Task<IEnumerable<Product>> GetProductsByBrand(string brand)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetProductsByBrandId(string brandId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetProductsByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetProductsByTypeId(string typeId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}
