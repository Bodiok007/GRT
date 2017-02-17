using GRT.DAL.Repositories.Interfaces.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.Base
{
    public abstract class BaseCRUDComplexKeyRepository<TEntity>
        : BaseRepository<TEntity>,
          IGetRepositoryOparation<TEntity>,
          IGetByIdComplexKeyRepositoryOperation<TEntity>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity>,
          IDeleteRepositoryOperation<TEntity> where TEntity : class
    {
        public BaseCRUDComplexKeyRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(TEntity item)
        {
            _dbSet.Add(item);
        }

        public void Delete(TEntity item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null)
        {
            var items = base.GetByCondition(filter, orderBy, includeProperties);

            return items;
        }

        public TEntity GetById(params object[] keys)
        {
            var item = _dbSet.Find(keys);

            return item;
        }

        public void Update(TEntity item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
