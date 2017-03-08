using GRT.DAL.Models.UserProject;
using GRT.DAL.Repositories.Base;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using GRT.DAL.Repositories.Interfaces.UserProject;

namespace GRT.DAL.Repositories.EF.UserProject
{
    public sealed class UserRepository 
        : BaseCRURepository<UserDal, Int32>
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
