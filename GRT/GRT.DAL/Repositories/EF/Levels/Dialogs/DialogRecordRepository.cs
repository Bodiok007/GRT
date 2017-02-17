using GRT.DAL.Models.Levels.Dialogs;
using GRT.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace GRT.DAL.Repositories.EF.Levels.Dialogs
{
    public class DialogRecordRepository
        : BaseCRUDRepository<DialogRecordDal, Int32>
    {
        public DialogRecordRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
