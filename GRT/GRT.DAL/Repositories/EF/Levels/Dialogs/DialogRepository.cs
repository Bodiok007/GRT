using GRT.DAL.Models.Levels.Dialogs;
using System;
using GRT.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Repositories.EF.Levels.Dialogs
{
    public class DialogRepository
        : BaseCRUDRepository<DialogDal, Int32>
    {
        public DialogRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
