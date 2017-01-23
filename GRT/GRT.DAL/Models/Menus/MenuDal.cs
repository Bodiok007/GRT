using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Menus
{
    [Table(name: "Menu")]
    public class MenuDal
    {
        public MenuDal()
        {
            MenuTranslates = new List<MenuTranslateDal>();
            MenuAttributeValues = new List<MenuAttributeValueDal>();
        }

        [Key]
        public Int32 Id { get; set; }
        public Int32? SubmenuId { get; set; }
        public Int32? MenuAttributeId { get; set; }
        public virtual MenuDal Submenu { get; set; }
        public virtual ICollection<MenuTranslateDal> MenuTranslates { get; set; }
        public virtual ICollection<MenuAttributeValueDal> MenuAttributeValues { get; set; }
    }
}
