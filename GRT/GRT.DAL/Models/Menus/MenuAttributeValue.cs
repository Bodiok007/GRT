using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Models.Menus
{
    public sealed class MenuAttributeValue
    {
        public Int32 Id { get; set; }
        public Int32 MenuId { get; set; }
        public Int32 MenuAttributeId { get; set; }
    }
}
