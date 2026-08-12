using Dto;

namespace Interfaces.ServiceManager;

public interface IProductService
{
    ProductDto findProductById(Guid id, bool trackChanges);
    IEnumerable<ProductDto> FindAllProductByName(bool trackChanges);
}
