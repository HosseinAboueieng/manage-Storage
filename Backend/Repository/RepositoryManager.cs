using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Interfaces.RepositoryInterFace;

namespace Repository;

public sealed class RepositoryManager:IRepositoryManager
{
    private readonly RepositoryContex _repositoryContext;
    private readonly Lazy<IProductRepository> _productRepository;
    private readonly Lazy<IDistibuterRepository> _ditsributerRepository;
    private readonly Lazy<IStorageRepository> _storageRipository;
    private readonly Lazy<IBuyFactorRrepository> _buyFactorRepository;
    private readonly Lazy<IGoupOfProductRepository> _groupOfProductRepository;

    public RepositoryManager(RepositoryContex repositoryContex)
    {
        _repositoryContext=repositoryContex;
        _productRepository = new Lazy<IProductRepository>(() => new ProductsRepository(repositoryContex));
        _ditsributerRepository = new Lazy<IDistibuterRepository>(() => new DitsributerRepository(repositoryContex));
        _storageRipository = new Lazy<IStorageRepository>(() => new StorageRepository(repositoryContex));
        _groupOfProductRepository=new Lazy<IGoupOfProductRepository>(()=>new GroupOfProductRepository(_repositoryContext));
        _buyFactorRepository=new Lazy<IBuyFactorRrepository>(()=> new BuyFactorReoisitory(_repositoryContext));
    }
    public IProductRepository Product=>_productRepository.Value;
    public IDistibuterRepository Distibuter=>_ditsributerRepository.Value;
    public IGoupOfProductRepository GoupOfProduct=>_groupOfProductRepository.Value;
    public IStorageRepository Storage=>_storageRipository.Value;
    public IBuyFactorRrepository BuyFactor=>_buyFactorRepository.Value;
    public async Task save()=>await _repositoryContext.SaveChangesAsync();
}
