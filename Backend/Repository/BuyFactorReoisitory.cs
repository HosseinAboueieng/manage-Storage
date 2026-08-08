using Entity.Models;
using Interfaces.RepositoryInterFace;

namespace Repository;

public class BuyFactorReoisitory:RepositoryBase<BuyFactor>,IBuyFactorRrepository
{
    public BuyFactorReoisitory(RepositoryContex repositoryContex):base(repositoryContex){}
}
