using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Levels.Dialogs
{
    [Table(name: "Dialog")]
    public class DialogDal
    {
        public DialogDal()
        {
            LevelDialogs = new List<LevelDialogDal>();
            DialogRecords = new List<DialogRecordDal>();
            DialogTexts = new List<DialogTextDal>();
        }

        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Details { get; set; }

        public virtual ICollection<LevelDialogDal> LevelDialogs { get; set; }
        public virtual ICollection<DialogRecordDal> DialogRecords { get; set; }
        public virtual ICollection<DialogTextDal> DialogTexts { get; set; }
    }
}
