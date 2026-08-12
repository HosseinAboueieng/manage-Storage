using Entity.Models;
using Interfaces.RepositoryInterFace;
using Microsoft.VisualBasic;

namespace Repository;

public class GroupOfProductRepository:RepositoryBase<GroupOfProduct>,IGoupOfProductRepository
{
       public GroupOfProductRepository(RepositoryContex repositoryContex):base(repositoryContex){}

}
