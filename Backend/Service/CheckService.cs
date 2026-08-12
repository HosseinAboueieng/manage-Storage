using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;
namespace Service

{
    internal class CheckService : ICheckService
    {
        private readonly IRepositoryManager _repository;
        private readonly IloggerManager _logger;
        public CheckService(IRepositoryManager repositoryManager,
        IloggerManager logger)
        {
            _repository = repositoryManager;
            _logger = logger;
        }
    }
}
