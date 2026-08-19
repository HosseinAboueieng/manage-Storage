using Interfaces.ServiceManager;
using Interfaces.RepositoryInterFace;
using Interfaces;
using AutoMapper;

namespace Service;

public class ServiceManager : ISeviceManager
{
    private readonly Lazy<IProductService> _productRepository;
    private readonly Lazy<IDistibuterSevice> _ditsributerRepository;
    private readonly Lazy<IStorageService> _storageRipository;
    private readonly Lazy<IBuyFactorService> _buyFactorRepository;
    private readonly Lazy<IGroupOfProductSevice> _groupOfProductRepository;

    public ServiceManager(IRepositoryManager repositoryManager,IloggerManager loggerManager,IMapper mapper)
    {
        _productRepository = new Lazy<IProductService>(() => new ProductService(repositoryManager, loggerManager,mapper));
        _ditsributerRepository = new Lazy<IDistibuterSevice>(() => new DistributerService(repositoryManager, loggerManager));
        _storageRipository = new Lazy<IStorageService>(() => new StorageService(repositoryManager, loggerManager));
        _groupOfProductRepository = new Lazy<IGroupOfProductSevice>(() => new GroupOfProuductService(repositoryManager, loggerManager,mapper));
        _buyFactorRepository = new Lazy<IBuyFactorService>(() => new BuyFactorService(repositoryManager, loggerManager));
    }


    public IProductService productService=>_productRepository.Value;

    public IDistibuterSevice distibuterSevice => _ditsributerRepository.Value;

    public IStorageService storageService => _storageRipository.Value;

    public IGroupOfProductSevice groupOfProductSevice => _groupOfProductRepository.Value;

    public IBuyFactorService buyFactor => _buyFactorRepository.Value;

}
