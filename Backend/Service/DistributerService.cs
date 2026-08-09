namespace Service;

using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;
using Microsoft.Extensions.Logging;

public class DistributerService : IDistibuterSevice
{
    private readonly IRepositoryManager _repository;
    private readonly ILogger _logger;
    public DistributerService(IRepositoryManager repositoryManager,
    ILogger logger)
    {
        _repository = repositoryManager;
        _logger = logger;
    }
}
