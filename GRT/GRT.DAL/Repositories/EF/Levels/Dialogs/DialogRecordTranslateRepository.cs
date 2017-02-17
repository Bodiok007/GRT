using GRT.DAL.Models.Levels.Dialogs;
using GRT.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Levels.Dialogs
{
    public class DialogRecordTranslateRepository
        : BaseCRUDComplexKeyRepository<DialogRecordTranslateDal>
    {
        public DialogRecordTranslateRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
