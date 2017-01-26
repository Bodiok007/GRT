using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Levels.Dialogs
{
    [Table(name: "DialogRecords")]
    public class DialogRecordDal
    {
        public DialogRecordDal()
        {
            DialogRecordTranslates = new List<DialogRecordTranslateDal>();
        }

        public Int32 Id { get; set; }
        public Int32 DialogId { get; set; }

        public virtual DialogDal Dialog { get; set; }
        public virtual ICollection<DialogRecordTranslateDal> DialogRecordTranslates { get; set; }
    }
}
