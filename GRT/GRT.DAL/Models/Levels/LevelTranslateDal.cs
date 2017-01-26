using GRT.DAL.Models.Languages;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Levels
{
    [Table(name: "LevelTranslate")]
    public class LevelTranslateDal
    {
        public Int32 LevelId { get; set; }
        public Int32 LanguageId { get; set; }
        public String LevelName { get; set; }

        public virtual LevelDal Level { get; set; }
        public virtual LanguageDal Language { get; set; }
    }
}
