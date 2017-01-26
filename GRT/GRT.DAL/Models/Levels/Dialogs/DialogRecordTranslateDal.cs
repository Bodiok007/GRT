using GRT.DAL.Models.Languages;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Levels.Dialogs
{
    [Table(name: "DialogRecordTranslate")]
    public class DialogRecordTranslateDal
    {
        public Int32 RecordId { get; set; }
        public Int32 LanguageId { get; set; }
        public Byte[] RecordValue { get; set; }

        public virtual LanguageDal Language { get; set; }
        public virtual DialogRecordDal Record { get; set; }
    }
}
