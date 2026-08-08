namespace Interfaces.RepositoryInterFace;

public interface IRepositoryManager
{
    IProductRepository Product{get;}
    IGoupOfProductRepository GoupOfProduct{get;}
    IDistibuterRepository Distibuter{get;}
    IStorageRepository Storage{get;}
    IBuyFactorRrepository BuyFactor{get;}
    Task save();
}
