using GRT.DAL.Models.Levels.Dialogs;
using GRT.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace GRT.DAL.Repositories.EF.Levels.Dialogs
{
    public class DialogTextRepository
        : BaseCRUDRepository<DialogTextDal, Int32>
    {
        public DialogTextRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
