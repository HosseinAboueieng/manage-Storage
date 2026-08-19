namespace Interfaces.RepositoryInterFace;

using Entity.EntityPrometre;

using Entity.Models;
public interface IProductRepository
{
    Products productById(Guid id ,bool trackChanges);
    IEnumerable<Products> GetProducts(bool trackChanges);
    Products productByName(ProductParametre productParametrs,bool trackChanges);
    Task productCreation(Products product);
}
