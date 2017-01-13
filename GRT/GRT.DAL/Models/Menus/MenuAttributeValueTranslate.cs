using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Models.Menus
{
    public sealed class MenuAttributeValueTranslate
    {
        public Int32 MenuAttributeValueId { get; set; }
        public Int32 LanguageId { get; set; }
        public String Value { get; set; }
    }
}
