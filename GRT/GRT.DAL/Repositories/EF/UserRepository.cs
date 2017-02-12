using GRT.DAL.Models.UserProject;
using GRT.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GRT.DAL.Repositories.Interfaces;
using System.Linq.Expressions;
using GRT.DAL.Repositories.Interfaces.Operations;

namespace GRT.DAL.Repositories.EF
{
    public sealed class UserRepository : BaseRepository<UserDal>, IUserRepository<UserDal> 
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public void Add(UserDal user)
        {
            _dbSet.Add(user);
        }

        public void Update(UserDal user)
        {
            _dbSet.Attach(user);
            _dbContext.Entry(user).State = EntityState.Modified;
        }

        public IQueryable<UserDal> Get(
            Expression<Func<UserDal, bool>> filter,
            Func<IQueryable<UserDal>, IOrderedQueryable<UserDal>> orderBy,
            string includeProperties)
        {
            var users = base.GetByCondition(filter, orderBy, includeProperties);

            return users;
        }

        public UserDal GetById(object id)
        {
            var user = _dbSet.Find();

            return user;
        }
    }
}
