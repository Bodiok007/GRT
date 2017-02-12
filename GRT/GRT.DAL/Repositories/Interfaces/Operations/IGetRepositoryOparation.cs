using System;
using System.Linq;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.Interfaces.Operations
{
    public interface IGetRepositoryOparation<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null
        );
    }
}
