using Catalog.Core.Entities;
using Catalog.Core.IRepositories;
using Catalog.Infrastructure.Data;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Repositories;

public class BrandRepository(ICatalogContext context) : IBrandRepository
{
    private readonly ICatalogContext _context = context;

    public async Task<IEnumerable<ProductBrand>> GetProductBrands()
    {
        return await _context.Brands.Find(x => true).ToListAsync();
    }
}
