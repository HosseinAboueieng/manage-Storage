namespace Service;

using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;


public class DistributerService : IDistibuterSevice
{
    private readonly IRepositoryManager _repository;
    private readonly IloggerManager _logger;
    public DistributerService(IRepositoryManager repositoryManager,
    IloggerManager logger)
    {
        _repository = repositoryManager;
        _logger = logger;
    }
}
