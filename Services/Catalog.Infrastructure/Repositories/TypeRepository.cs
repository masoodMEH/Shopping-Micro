using Catalog.Core.Entities;
using Catalog.Core.IRepositories;
using Catalog.Infrastructure.Data;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Repositories;

public class TypeRepository(ICatalogContext context) : ITypeRepository
{
    private readonly ICatalogContext _context = context;


    public async Task<IEnumerable<ProductType>> GetProductTypes()
    {
        return await _context.Types.Find(x => true).ToListAsync();
    }
}
