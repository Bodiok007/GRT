using GRT.DAL.Models.Levels;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Levels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.EF.Levels
{
    public class LevelDialogRepository
        : BaseRepository<LevelDialogDal>,
          ILevelDialogRepository<LevelDialogDal>
    {
        public LevelDialogRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(LevelDialogDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(LevelDialogDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<LevelDialogDal> Get(
            Expression<Func<LevelDialogDal, bool>> filter = null,
            Func<IQueryable<LevelDialogDal>, IOrderedQueryable<LevelDialogDal>> orderBy = null,
            string includeProperties = null)
        {
            var levelDialogs = base.GetByCondition(filter, orderBy, includeProperties);

            return levelDialogs;
        }

        public LevelDialogDal GetById(params object[] keys)
        {
            var levelDialog = _dbSet.Find(keys);

            return levelDialog;
        }

        public void Update(LevelDialogDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
