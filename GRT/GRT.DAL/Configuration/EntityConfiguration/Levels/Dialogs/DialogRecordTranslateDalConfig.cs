using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Levels.Dialogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Levels.Dialogs
{
    public class DialogRecordTranslateDalConfig
        : EntityMappingConfiguration<DialogRecordTranslateDal>
    {
        public override void Map(EntityTypeBuilder<DialogRecordTranslateDal> builder)
        {
            builder.HasKey(recordTransl => new { recordTransl.RecordId, recordTransl.LanguageId });

            builder
                .HasOne(recordTransl => recordTransl.Record)
                .WithMany(record => record.DialogRecordTranslates)
                .HasForeignKey(recordTransl => recordTransl.RecordId)
                .IsRequired()
                .HasConstraintName("FK_RecordTranslate_Record");

            builder
                .HasOne(recordTransl => recordTransl.Language)
                .WithMany(language => language.DialogRecordTranslates)
                .HasForeignKey(recordTransl => recordTransl.LanguageId)
                .IsRequired()
                .HasConstraintName("FK_RecordTranslate_Language");
        }
    }
}
