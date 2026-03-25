using Catalog.Core.Entities;

namespace Catalog.Core.IRepositories;

public interface ITypeRepository
{
    Task<IEnumerable<ProductType>> GetProductTypes();
}
