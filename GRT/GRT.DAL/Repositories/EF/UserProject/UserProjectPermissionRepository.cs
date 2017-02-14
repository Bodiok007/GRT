using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.UserProject;
using GRT.DAL.Models.UserProject;
using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.UserProject
{
    public class UserProjectPermissionRepository
        : BaseRepository<UserProjectPermissionDal>,
          IUserProjectPermissionRepository<UserProjectPermissionDal>
    {
        public UserProjectPermissionRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(UserProjectPermissionDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(UserProjectPermissionDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<UserProjectPermissionDal> Get(
            Expression<Func<UserProjectPermissionDal, bool>> filter = null, 
            Func<IQueryable<UserProjectPermissionDal>, IOrderedQueryable<UserProjectPermissionDal>> orderBy = null, 
            string includeProperties = null)
        {
            var userProjectPermissions = base.GetByCondition(filter, orderBy, includeProperties);

            return userProjectPermissions;
        }

        public UserProjectPermissionDal GetById(params object[] keys)
        {
            var userProjectPermission = _dbSet.Find(keys);

            return userProjectPermission;
        }

        public void Update(UserProjectPermissionDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
