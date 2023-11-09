using System.Linq.Expressions;

namespace Examples.Core.Interfaces.Database.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity?> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}