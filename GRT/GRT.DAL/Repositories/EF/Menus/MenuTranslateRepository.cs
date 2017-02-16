using GRT.DAL.Models.Menus;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Menus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.EF.Menus
{
    public class MenuTranslateRepository
        : BaseRepository<MenuTranslateDal>,
          IMenuTranslateRepository<MenuTranslateDal>
    {
        public MenuTranslateRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(MenuTranslateDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(MenuTranslateDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<MenuTranslateDal> Get(
            Expression<Func<MenuTranslateDal, bool>> filter = null,
            Func<IQueryable<MenuTranslateDal>, IOrderedQueryable<MenuTranslateDal>> orderBy = null,
            string includeProperties = null)
        {
            var menuTranslates = base.GetByCondition(filter, orderBy, includeProperties);

            return menuTranslates;
        }

        public MenuTranslateDal GetById(params object[] keys)
        {
            var menuTranslate = _dbSet.Find(keys);

            return menuTranslate;
        }

        public void Update(MenuTranslateDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
