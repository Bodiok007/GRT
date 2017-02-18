using GRT.DAL.Models.Menus;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Menus;
using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Menus
{
    public class MenuAttributeRepository
        : BaseRepository<MenuAttributeDal>,
          IMenuAttributeRepository<MenuAttributeDal, Int32>
    {
        public MenuAttributeRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(MenuAttributeDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(MenuAttributeDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<MenuAttributeDal> Get(
            Expression<Func<MenuAttributeDal, bool>> filter = null, 
            Func<IQueryable<MenuAttributeDal>, IOrderedQueryable<MenuAttributeDal>> orderBy = null, 
            string includeProperties = null)
        {
            var menuAttributes = base.GetByCondition(filter, orderBy, includeProperties);

            return menuAttributes;
        }

        public MenuAttributeDal GetById(int id)
        {
            var menuAttribute = _dbSet.Find(id);

            return menuAttribute;
        }

        public void Update(MenuAttributeDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified; throw new NotImplementedException();
        }
    }
}
