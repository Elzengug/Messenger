using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Data.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        protected GenericRepository(IDbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            DbSet = dbContext.Set<TEntity>();
        }

        protected IDbSet<TEntity> DbSet { get; }
        protected IDbContext DbContext { get; }
        protected virtual IQueryable<TEntity> DetachedQueryable => DbSet.AsNoTracking();

        public async Task<ICollection<TEntity>> GetItemsAsync()
        {
            return await DetachedQueryable.ToListAsync();
        }

        public async Task<ICollection<TEntity>> GetItemsAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> convertQuery)
        {
            if (convertQuery == null)
                throw new ArgumentNullException(nameof(convertQuery));

            return await convertQuery(DetachedQueryable).ToListAsync();
        }

        public async Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return await DetachedQueryable.Where(predicate).ToListAsync();
        }

        public async Task<TEntity> FindFirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return await DetachedQueryable.FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> AddAsync(TEntity item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            DbSet.Add(item);
            await DbContext.SaveChangesAsync();
            return item;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            DbContext.Entry(item).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
            return item;
        }

        public virtual async Task<bool> RemoveAsync(TEntity item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            try
            {
                DbContext.Entry(item).State = EntityState.Deleted;
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
