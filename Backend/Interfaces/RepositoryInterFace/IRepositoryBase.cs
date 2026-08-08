using System.Linq.Expressions;

namespace Interfaces;

public interface IRepositoryBase<T>
{
    IQueryable<T> findAll(bool trackChanges);
    IQueryable<T> findByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    void create(T entity);
    void update(T entity);
    void delete(T entity); 
}
