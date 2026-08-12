using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;


namespace Service
{
    internal class BuyFactorService : IBuyFactorService
    {
        private readonly IRepositoryManager _repository;
        private readonly IloggerManager _logger;
        public BuyFactorService(IRepositoryManager repositoryManager,
        IloggerManager logger)
        {
            _repository = repositoryManager;
            _logger = logger;
        }
    }
}
