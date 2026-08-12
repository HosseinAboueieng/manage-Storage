using Entity.Models;
using Interfaces.RepositoryInterFace;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class ProductsRepository :RepositoryBase<Products>,IProductRepository
{
    public ProductsRepository(RepositoryContex repositoryContex):base(repositoryContex){}

    public IEnumerable<Products> GetProducts(bool trackChanges)
    {
        return FindAll(trackChanges).Include(p =>p.groupOfProduct)
        .ToList();
    }


    public Products productById(Guid id,bool trackChanges)
    {
        return FindByCondition(p => p.id.Equals(id),trackChanges).Include(p =>p.groupOfProduct).SingleOrDefault();
    }

}
