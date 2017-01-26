using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Menus
{
    [Table(name: "MenuAttributeValue")]
    public class MenuAttributeValueDal
    {
        public MenuAttributeValueDal()
        {
            MenuAttributeValueTranslates = new List<MenuAttributeValueTranslateDal>();
        }

        public Int32 Id { get; set; }
        public Int32 MenuId { get; set; }
        public Int32 MenuAttributeId { get; set; }

        public virtual MenuDal Menu { get; set; }
        public virtual MenuAttributeDal MenuAttribute { get; set; }
        public virtual ICollection<MenuAttributeValueTranslateDal> MenuAttributeValueTranslates { get; set; }
    }
}
