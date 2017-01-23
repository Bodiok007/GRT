using GRT.DAL.Models.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Languages
{
    [Table(name: "Language")]
    public class LanguageDal
    {
        public LanguageDal()
        {
            MenuTranslates = new List<MenuTranslateDal>();
            MenuAttributeTranslates = new List<MenuAttributeTranslateDal>();
        }

        public Int32 Id { get; set; }
        public String Name { get; set; }
        public virtual ICollection<MenuTranslateDal> MenuTranslates { get; set; }
        public virtual ICollection<MenuAttributeTranslateDal> MenuAttributeTranslates { get; set; }
        public virtual ICollection<MenuAttributeValueTranslateDal> MenuAttributeValueTranslates { get; set; }
    }
}
