using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;


namespace Service;

public class ProductService:IProductService
{
    private readonly IRepositoryManager _repository;
    private readonly IloggerManager _logger;
    public ProductService(IRepositoryManager repositoryManager,
    IloggerManager logger)
    {
        _repository=repositoryManager;
        _logger=logger;
    }
}
