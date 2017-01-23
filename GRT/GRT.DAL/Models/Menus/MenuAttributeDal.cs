using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Menus
{
    [Table(name: "MenuAttributeDal")]
    public class MenuAttributeDal
    {
        public MenuAttributeDal()
        {
            MenuAttributeValues = new List<MenuAttributeValueDal>();
            MenuAttributes = new List<MenuAttributeTranslateDal>();
        }

        public Int32 Id { get; set; }
        public virtual ICollection<MenuAttributeValueDal> MenuAttributeValues { get; set; }
        public virtual ICollection<MenuAttributeTranslateDal> MenuAttributes { get; set; }
    }
}
