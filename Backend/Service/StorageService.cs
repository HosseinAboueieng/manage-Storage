using Interfaces.ServiceManager;
using Interfaces.RepositoryInterFace;
using NLog;

namespace Service;

public class StorageService:IStorageService
{
        private readonly IRepositoryManager _repository;
    private readonly ILogger _logger;
    public StorageService(IRepositoryManager repositoryManager,
    ILogger logger)
    {
        _repository=repositoryManager;
        _logger=logger;
    }
}
