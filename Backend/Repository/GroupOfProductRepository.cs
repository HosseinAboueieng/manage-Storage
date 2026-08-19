using Entity.Models;
using Interfaces.RepositoryInterFace;
using Microsoft.VisualBasic;

namespace Repository;

public class GroupOfProductRepository:RepositoryBase<GroupOfProduct>,IGoupOfProductRepository
{
       public GroupOfProductRepository(RepositoryContex repositoryContex):base(repositoryContex){}

    public async Task CreateGroupOfProduct(GroupOfProduct groupOfProduct)
    {
        Create(groupOfProduct);
    }

    public async Task<IEnumerable<GroupOfProduct>> FindAllGroupOfProudct(bool trackChange)
    {
       return  FindAll(trackChange).ToList();
    }
}
