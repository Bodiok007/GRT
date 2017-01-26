using System;
using GRT.DAL.Models.Languages;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Menus
{
    [Table(name: "MenuTranslate")]
    public class MenuTranslateDal
    {
        public Int32 MenuId { get; set; }
        public Int32 LanguageId { get; set; }
        public String MenuName { get; set; }

        public virtual MenuDal Menu { get; set; }
        public virtual LanguageDal Language { get; set; }
    }
}
