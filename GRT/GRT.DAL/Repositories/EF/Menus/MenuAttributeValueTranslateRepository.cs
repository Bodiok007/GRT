using GRT.DAL.Models.Menus;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Menus;
using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Menus
{
    public class MenuAttributeValueTranslateRepository
        : BaseRepository<MenuAttributeValueTranslateDal>,
          IMenuAttributeValueTranslateRepository<MenuAttributeValueTranslateDal>
    {
        public MenuAttributeValueTranslateRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(MenuAttributeValueTranslateDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(MenuAttributeValueTranslateDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<MenuAttributeValueTranslateDal> Get(
            Expression<Func<MenuAttributeValueTranslateDal, bool>> filter = null,
            Func<IQueryable<MenuAttributeValueTranslateDal>, IOrderedQueryable<MenuAttributeValueTranslateDal>> orderBy = null,
            string includeProperties = null)
        {
            var menuAttributeValueTranslates = base.GetByCondition(filter, orderBy, includeProperties);

            return menuAttributeValueTranslates;
        }

        public MenuAttributeValueTranslateDal GetById(params object[] keys)
        {
            var menuAttributeValueTranslate = _dbSet.Find(keys);

            return menuAttributeValueTranslate;
        }

        public void Update(MenuAttributeValueTranslateDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
