using GRT.DAL.Models.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Models.Menus
{
    [Table(name: "MenuAttributeValueTranslate")]
    public class MenuAttributeValueTranslateDal
    {
        public Int32 MenuAttributeValueId { get; set; }
        public Int32 LanguageId { get; set; }
        public String Value { get; set; }
        public virtual MenuAttributeValueDal MenuAttributeValue { get; set; }
        public virtual LanguageDal Language { get; set; }
    }
}
