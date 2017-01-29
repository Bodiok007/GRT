using GRT.DAL.Models.UserProject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Models.Levels
{
    [Table(name: "Level")]
    public class LevelDal
    {
        public LevelDal()
        {
            LevelTranslates = new List<LevelTranslateDal>();
            LevelDialogs = new List<LevelDialogDal>();
        }

        public Int32 Id { get; set; }
        public Int32 ProjectId { get; set; }

        public virtual ProjectDal Project { get; set; }
        public virtual ICollection<LevelTranslateDal> LevelTranslates { get; set; }
        public virtual ICollection<LevelDialogDal> LevelDialogs { get; set; }
    }
}
