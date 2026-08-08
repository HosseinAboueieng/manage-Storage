namespace Repository;
using Entity.Models;
using Interfaces.RepositoryInterFace;

public class DitsributerRepository:RepositoryBase<Distributer>,IDistibuterRepository
{
    public DitsributerRepository(RepositoryContex repositoryContex):base(repositoryContex){}
}
