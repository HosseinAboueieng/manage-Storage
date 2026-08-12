using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;
using Microsoft.Extensions.Logging;

namespace Service
{
    internal class GroupOfProuductService : IGroupOfProductSevice
    {
        private readonly IRepositoryManager _repository;
        private readonly ILogger _logger;
        public GroupOfProuductService(IRepositoryManager repositoryManager,
        ILogger logger)
        {
            _repository = repositoryManager;
            _logger = logger;
        }
    }
}
