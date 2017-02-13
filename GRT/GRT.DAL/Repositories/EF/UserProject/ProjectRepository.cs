using GRT.DAL.Models.UserProject;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.UserProject;
using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.UserProject
{
    public class ProjectRepository
        : BaseRepository<ProjectDal>,
          IProjectRepository<ProjectDal>
    {
        public ProjectRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(ProjectDal item)
        {
            _dbSet.Add(item);
        }

        public void Delete(ProjectDal item)
        {
            if (_dbContext.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }

            _dbSet.Remove(item);
        }

        public IQueryable<ProjectDal> Get(
            Expression<Func<ProjectDal, bool>> filter = null, 
            Func<IQueryable<ProjectDal>, IOrderedQueryable<ProjectDal>> orderBy = null, 
            string includeProperties = null)
        {
            var projects = base.GetByCondition(filter, orderBy, includeProperties);

            return projects;
        }

        public ProjectDal GetById(object id)
        {
            var project = _dbSet.Find();

            return project;
        }

        public void Update(ProjectDal item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
