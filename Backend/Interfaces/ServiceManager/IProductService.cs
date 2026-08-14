using Dto;
using Entity.EntityPrometre;

namespace Interfaces.ServiceManager;

public interface IProductService
{
    ProductDto findProductById(Guid id, bool trackChanges);
    IEnumerable<ProductDto> FindAllProductByName(bool trackChanges);
    ProductDto findProductByName(ProductParametre productParametre, bool trackChanges);
}
