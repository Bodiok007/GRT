using GRT.DAL.Models.Levels;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Levels;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.EF.Levels
{
    public class LevelRepository
        : BaseRepository<LevelDal>,
          ILevelRepository<LevelDal, Int32>
    {
        public LevelRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(LevelDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(LevelDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<LevelDal> Get(
            Expression<Func<LevelDal, bool>> filter = null,
            Func<IQueryable<LevelDal>, IOrderedQueryable<LevelDal>> orderBy = null,
            string includeProperties = null)
        {
            var levels = base.GetByCondition(filter, orderBy, includeProperties);

            return levels;
        }

        public LevelDal GetById(int id)
        {
            var level = _dbSet.Find(id);

            return level;
        }

        public void Update(LevelDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
