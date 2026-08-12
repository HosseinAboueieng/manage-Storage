using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;

namespace Service
{
    internal class StorageService : IStorageService
    {
        private readonly IRepositoryManager _repository;
        private readonly IloggerManager _logger;
        public StorageService(IRepositoryManager repositoryManager,
        IloggerManager logger)
        {
            _repository = repositoryManager;
            _logger = logger;
        }
    }
}
