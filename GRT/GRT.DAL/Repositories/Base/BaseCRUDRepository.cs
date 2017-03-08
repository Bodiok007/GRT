﻿using System;
using System.Linq;
using System.Linq.Expressions;
using GRT.DAL.Repositories.Interfaces.Operations;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.Base
{
    public abstract class BaseCRUDRepository<TEntity, TKey>
        : BaseRepository<TEntity>, 
          IGetRepositoryOparation<TEntity>,
          IGetByIdRepositoryOperation<TEntity, TKey>,
          IUpdateRepositoryOparation<TEntity>,
          IAddRepositoryOparation<TEntity>,
          IDeleteRepositoryOperation<TEntity> where TEntity : class
    {
        public BaseCRUDRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public virtual void Add(TEntity item)
        {
            _dbSet.Add(item);
        }

        public virtual void Delete(TEntity item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public virtual IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null)
        {
            var items = base.GetByCondition(filter, orderBy, includeProperties);

            return items;
        }

        public virtual TEntity GetById(TKey id)
        {
            var item = _dbSet.Find(id);

            return item;
        }

        public virtual void Update(TEntity item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
