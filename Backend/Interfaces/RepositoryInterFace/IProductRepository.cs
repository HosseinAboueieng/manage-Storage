namespace Interfaces.RepositoryInterFace;
using Entity.Models;
public interface IProductRepository
{
    Products productById(Guid id ,bool trackChanges);
    IEnumerable<Products> GetProducts(bool trackChanges);
}
