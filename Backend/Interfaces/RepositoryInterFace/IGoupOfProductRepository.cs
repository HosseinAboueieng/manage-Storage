using Entity.Models;

namespace Interfaces.RepositoryInterFace;

public interface IGoupOfProductRepository
{
    Task CreateGroupOfProduct(GroupOfProduct groupOfProduct);
   Task< IEnumerable<GroupOfProduct>> FindAllGroupOfProudct(bool trackChange);
}
