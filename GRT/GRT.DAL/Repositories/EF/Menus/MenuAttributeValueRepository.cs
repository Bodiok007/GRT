using GRT.DAL.Models.Menus;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Menus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GRT.DAL.Repositories.EF.Menus
{
    public class MenuAttributeValueRepository
        : BaseRepository<MenuAttributeValueDal>,
          IMenuAttributeValueRepository<MenuAttributeValueDal, Int32>
    {
        public MenuAttributeValueRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(MenuAttributeValueDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(MenuAttributeValueDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<MenuAttributeValueDal> Get(
            Expression<Func<MenuAttributeValueDal, bool>> filter = null,
            Func<IQueryable<MenuAttributeValueDal>, IOrderedQueryable<MenuAttributeValueDal>> orderBy = null,
            string includeProperties = null)
        {
            var menuAttributeValues = base.GetByCondition(filter, orderBy, includeProperties);

            return menuAttributeValues;
        }

        public MenuAttributeValueDal GetById(int id)
        {
            var menuAttributeValue = _dbSet.Find(id);

            return menuAttributeValue;
        }

        public void Update(MenuAttributeValueDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
