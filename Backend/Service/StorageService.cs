using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;
using Microsoft.Extensions.Logging;

namespace Service
{
    internal class StorageService : IStorageService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILogger _logger;
        public StorageService(IRepositoryManager repositoryManager,
        ILogger logger)
        {
            _repository = repositoryManager;
            _logger = logger;
        }
    }
}
