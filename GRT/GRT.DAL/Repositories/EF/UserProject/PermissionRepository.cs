using GRT.DAL.Models.UserProject;
using GRT.DAL.Repositories.Interfaces.UserProject;
using System;
using System.Linq;
using System.Linq.Expressions;
using GRT.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.UserProject
{
    public sealed class PermissionRepository 
        : BaseRepository<PermissionDal>,
          IPermissionRepository<PermissionDal>
    {
        public PermissionRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<PermissionDal> Get(
            Expression<Func<PermissionDal, bool>> filter = null, 
            Func<IQueryable<PermissionDal>, IOrderedQueryable<PermissionDal>> orderBy = null, 
            string includeProperties = null)
        {
            var permissions = base.GetByCondition(filter, orderBy, includeProperties);

            return permissions;
        }

        public PermissionDal GetById(object id)
        {
            var permission = _dbSet.Find();

            return permission;
        }
    }
}
