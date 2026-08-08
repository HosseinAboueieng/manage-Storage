using Entity.Models;
using Interfaces.RepositoryInterFace;

namespace Repository;

public class StorageRepository : RepositoryBase<Storage>, IStorageRepository
{
    public StorageRepository(RepositoryContex repositoryContex):base(repositoryContex){}
}

