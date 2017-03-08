using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.Base
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        protected BaseRepository(DbContext dataContext)
        {
            _dbContext = dataContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        protected IQueryable<TEntity> Query
        {
            get { return _dbSet; }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        protected IQueryable<TEntity> GetByCondition(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null)
        {
            IQueryable<TEntity> query = Query;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!String.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        internal DbContext _dbContext;
        internal DbSet<TEntity> _dbSet;
    }
}
