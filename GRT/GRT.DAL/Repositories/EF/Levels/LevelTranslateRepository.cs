using GRT.DAL.Models.Levels;
using GRT.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Levels
{
    public class LevelTranslateRepository
        : BaseCRUDComplexKeyRepository<LevelTranslateDal>
    {
        public LevelTranslateRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
