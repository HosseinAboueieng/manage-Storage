using System.Linq.Expressions;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected RepositoryContex _repositoryContex;

    public RepositoryBase(RepositoryContex repositoryContex)
    {
        _repositoryContex=repositoryContex;
    }
    public void Create(T entity)=>_repositoryContex.Set<T>().Add(entity);

    public void Delete(T entity)=>_repositoryContex.Set<T>().Remove(entity);

    public IQueryable<T> FindAll(bool trackChanges)=>!trackChanges ? 
    _repositoryContex.Set<T>() 
    .AsNoTracking() : 
    _repositoryContex.Set<T>(); 

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool TrackChange)
    =>!TrackChange?
    _repositoryContex.Set<T>().Where(expression)
    .AsNoTracking():
    _repositoryContex.Set<T>().Where(expression);

    public void Update(T entity)=>_repositoryContex.Set<T>().Update(entity);

}
