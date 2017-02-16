using GRT.DAL.Models.Menus;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Menus
{
    public class MenuRepository
        : BaseRepository<MenuDal>,
          IMenuRepository<MenuDal, Int32>
    {
        public MenuRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(MenuDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(MenuDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<MenuDal> Get(
            Expression<Func<MenuDal, bool>> filter = null, 
            Func<IQueryable<MenuDal>, IOrderedQueryable<MenuDal>> orderBy = null, 
            string includeProperties = null)
        {
            var menus = base.GetByCondition(filter, orderBy, includeProperties);

            return menus;
        }

        public MenuDal GetById(int id)
        {
            var menu = _dbSet.Find(id);

            return menu;
        }

        public void Update(MenuDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
