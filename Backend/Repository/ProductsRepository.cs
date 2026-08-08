using Entity.Models;
using Interfaces.RepositoryInterFace;

namespace Repository;

public class ProductsRepository :RepositoryBase<Products>,IProductRepository
{
    public ProductsRepository(RepositoryContex repositoryContex):base(repositoryContex){}
}
