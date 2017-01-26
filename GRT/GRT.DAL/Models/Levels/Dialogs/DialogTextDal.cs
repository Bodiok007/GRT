using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Levels.Dialogs
{
    [Table(name: "DialogText")]
    public class DialogTextDal
    {
        public DialogTextDal()
        {
            DialogTextTranslates = new List<DialogTextTranslateDal>();
        }

        public Int32 Id { get; set; }
        public Int32 DialogId { get; set; }

        public virtual DialogDal Dialog { get; set; }
        public virtual ICollection<DialogTextTranslateDal> DialogTextTranslates { get; set; }
    }
}
