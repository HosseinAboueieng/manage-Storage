using Entity.Models;
using Interfaces.RepositoryInterFace;
using Microsoft.EntityFrameworkCore;
using Entity.EntityPrometre;

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

    public Products productByName(ProductParametre productParametrs, bool trackChanges)
    {
        var products=FindAll(trackChanges).Where(p => p.ProductsName.Equals(productParametrs.search)).Include(p =>p.groupOfProduct).SingleOrDefault();
        if(products==null)
        {
            return null;
        }
        else
        {
            return products;
        }
    }
}
