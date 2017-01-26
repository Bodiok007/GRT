using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Levels.Dialogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Levels.Dialogs
{
    public class DialogRecordDalConfig
        : EntityMappingConfiguration<DialogRecordDal>
    {
        public override void Map(EntityTypeBuilder<DialogRecordDal> builder)
        {
            builder
                .HasOne(record => record.Dialog)
                .WithMany(dialog => dialog.DialogRecords)
                .HasForeignKey(record => record.DialogId)
                .IsRequired()
                .HasConstraintName("FK_RecordDal_Record");
        }
    }
}
