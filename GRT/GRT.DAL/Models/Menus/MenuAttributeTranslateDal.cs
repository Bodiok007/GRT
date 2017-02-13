using GRT.DAL.Models.Languages;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Menus
{
    [Table(name: "MenuAttributeTranslate")]
    public class MenuAttributeTranslateDal
    {
        public Int32 MenuAttributeId { get; set; }
        public Int32 LanguageId { get; set; }
        public String AttributeName { get; set; }

        public virtual LanguageDal Language { get; set; }
        public virtual MenuAttributeDal MenuAttribute { get; set; }
    }
}
