using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Levels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Configuration.EntityConfiguration.Levels.Dialogs
{
    public class LevelDialogDalConfig
        : EntityMappingConfiguration<LevelDialogDal>
    {
        public override void Map(EntityTypeBuilder<LevelDialogDal> builder)
        {
            builder.HasKey(lvlDialog => new { lvlDialog.LevelId, lvlDialog.DialogId });

            builder
                .HasOne(lvlDialog => lvlDialog.Level)
                .WithMany(lvl => lvl.LevelDialogs)
                .HasForeignKey(lvlDialog => lvlDialog.LevelId)
                .IsRequired()
                .HasConstraintName("FK_LevelDialog_Level");

            builder
                .HasOne(lvlDialog => lvlDialog.Dialog)
                .WithMany(dialog => dialog.LevelDialogs)
                .HasForeignKey(lvlDialog => lvlDialog.DialogId)
                .IsRequired()
                .HasConstraintName("FK_LevelDialog_Dialog");
        }
    }
}
