using GRT.DAL.Models.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Models.Menus
{
    public class MenuAttributeTranslateDal
    {
        public Int32 MenuAttributeId { get; set; }
        public Int32 LanguageId { get; set; }
        public String AttributeName { get; set; }

        public virtual LanguageDal Language { get; set; }
        public virtual MenuAttributeDal MenuAttribute { get; set; }
    }
}
