using Examples.Core.Database.Repositories;
using Examples.Database.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Examples.Database.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ExamplesContext _context;
        protected IQueryable<TEntity> Query;

        public RepositoryBase(ExamplesContext context)
        {
            _context = context;
            Query = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            ResetQuery();
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            ResetQuery();
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            var result = Query.Where(predicate);
            ResetQuery();
            return result;
        }

        public async Task<TEntity?> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var result = await Query.SingleOrDefaultAsync(predicate);
            ResetQuery();
            return result;
        }

        /// <summary>
        /// Reset the query variable so that subsequent query with the same object from the caller is reinitialized.
        /// </summary>
        private void ResetQuery()
        {
            Query = _context.Set<TEntity>();
        }
    }
}
