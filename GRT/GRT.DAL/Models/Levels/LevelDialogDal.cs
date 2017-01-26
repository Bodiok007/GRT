using GRT.DAL.Models.Levels.Dialogs;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Levels
{
    [Table(name: "LevelDialog")]
    public class LevelDialogDal
    {
        public Int32 LevelId { get; set; }
        public Int32 DialogId { get; set; }

        public virtual LevelDal Level { get; set; }
        public virtual DialogDal Dialog { get; set; }
    }
}
