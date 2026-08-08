using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;
using NLog;

namespace Service;

public class ProductService:IProductService
{
    private readonly IRepositoryManager _repository;
    private readonly ILogger _logger;
    public ProductService(IRepositoryManager repositoryManager,
    ILogger logger)
    {
        _repository=repositoryManager;
        _logger=logger;
    }
}
