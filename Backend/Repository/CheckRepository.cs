using Entity.Models;
using Interfaces.RepositoryInterFace;

namespace Repository
{
    internal class CheckRepository : RepositoryBase<Check>, ICheckRepository
    {
        public CheckRepository(RepositoryContex repositoryContex) : base(repositoryContex) { }
    }
}
