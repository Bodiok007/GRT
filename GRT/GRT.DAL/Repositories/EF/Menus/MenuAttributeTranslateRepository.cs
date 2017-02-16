using GRT.DAL.Models.Menus;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Menus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.EF.Menus
{
    public class MenuAttributeTranslateRepository
        : BaseRepository<MenuAttributeTranslateDal>,
          IMenuAttributeTranslateRepository<MenuAttributeTranslateDal>
    {
        public MenuAttributeTranslateRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(MenuAttributeTranslateDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(MenuAttributeTranslateDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<MenuAttributeTranslateDal> Get(
            Expression<Func<MenuAttributeTranslateDal, bool>> filter = null,
            Func<IQueryable<MenuAttributeTranslateDal>, IOrderedQueryable<MenuAttributeTranslateDal>> orderBy = null,
            string includeProperties = null)
        {
            var menuAttributeTranslates = base.GetByCondition(filter, orderBy, includeProperties);

            return menuAttributeTranslates;
        }

        public MenuAttributeTranslateDal GetById(params object[] keys)
        {
            var menuAttributeTranslate = _dbSet.Find(keys);

            return menuAttributeTranslate;
        }

        public void Update(MenuAttributeTranslateDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
