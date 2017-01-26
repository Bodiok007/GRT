using GRT.DAL.Models.Levels;
using GRT.DAL.Models.Levels.Dialogs;
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
            MenuAttributeValueTranslates = new List<MenuAttributeValueTranslateDal>();

            LevelTranslates = new List<LevelTranslateDal>();
            DialogTextTranslates = new List<DialogTextTranslateDal>();
            DialogRecordTranslates = new List<DialogRecordTranslateDal>();
        }

        public Int32 Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<MenuTranslateDal> MenuTranslates { get; set; }
        public virtual ICollection<MenuAttributeTranslateDal> MenuAttributeTranslates { get; set; }
        public virtual ICollection<MenuAttributeValueTranslateDal> MenuAttributeValueTranslates { get; set; }

        public virtual ICollection<LevelTranslateDal> LevelTranslates { get; set; }
        public virtual ICollection<DialogTextTranslateDal> DialogTextTranslates { get; set; }
        public virtual ICollection<DialogRecordTranslateDal> DialogRecordTranslates { get; set; }
    }
}
