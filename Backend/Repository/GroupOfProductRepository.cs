using Entity.Models;
using Interfaces.RepositoryInterFace;

namespace Repository;

public class GroupOfProductRepository:RepositoryBase<GroupOfProduct>,IGoupOfProductRepository
{
       public GroupOfProductRepository(RepositoryContex repositoryContex):base(repositoryContex){}
}
