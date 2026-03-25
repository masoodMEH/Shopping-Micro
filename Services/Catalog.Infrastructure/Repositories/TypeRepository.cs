using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;

namespace Catalog.Infrastructure.Repositories;

public class TypeRepository(ICatalogContext context) : ITypeRepository
{
    private readonly ICatalogContext _context = context;


    public Task<IEnumerable<ProductType>> GetProductTypes()
    {
        throw new NotImplementedException();
    }
}
