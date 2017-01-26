using GRT.DAL.Models.Languages;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Levels.Dialogs
{
    [Table(name: "DialogTextTranslate")]
    public class DialogTextTranslateDal
    {
        public Int32 DialogTextId { get; set; }
        public Int32 LanguageId { get; set; }
        public String Text { get; set; }

        public virtual LanguageDal Language { get; set; }
        public virtual DialogTextDal DialogText { get; set; }
    }
}
