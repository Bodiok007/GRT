using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Models.Menus
{
    public sealed class MenuAttributeTranslateDal
    {
        public Int32 MenuId { get; set; }
        public Int32 LanguageId { get; set; }
        public String AttributeName { get; set; }
    }
}
