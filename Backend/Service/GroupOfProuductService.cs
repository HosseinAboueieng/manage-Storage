using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;


namespace Service
{
    internal class GroupOfProuductService : IGroupOfProductSevice
    {
        private readonly IRepositoryManager _repository;
        private readonly IloggerManager _logger;
        public GroupOfProuductService(IRepositoryManager repositoryManager,
        IloggerManager logger)
        {
            _repository = repositoryManager;
            _logger = logger;
        }
    }
}
