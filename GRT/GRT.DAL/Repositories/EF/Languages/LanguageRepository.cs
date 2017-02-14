using GRT.DAL.Models.Languages;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.Interfaces.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Languages
{
    public class LanguageRepository
        : BaseRepository<LanguageDal>,
          ILanguageRepository<LanguageDal, Int32>
    {
        public LanguageRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public void Add(LanguageDal language)
        {
            _dbSet.Add(language);
        }

        public IQueryable<LanguageDal> Get(
            Expression<Func<LanguageDal, bool>> filter = null, 
            Func<IQueryable<LanguageDal>, IOrderedQueryable<LanguageDal>> orderBy = null, 
            string includeProperties = null)
        {
            var languages = base.GetByCondition(filter, orderBy, includeProperties);

            return languages;
        }

        public LanguageDal GetById(int id)
        {
            var language = _dbSet.Find();

            return language;
        }

        public void Update(LanguageDal language)
        {
            _dbSet.Attach(language);
            _dbContext.Entry(language).State = EntityState.Modified;
        }
    }
}
