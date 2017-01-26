using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Levels.Dialogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Levels.Dialogs
{
    public class DialogTextDalConfig
        : EntityMappingConfiguration<DialogTextDal>
    {
        public override void Map(EntityTypeBuilder<DialogTextDal> builder)
        {
            builder
                .HasOne(dialogTxt => dialogTxt.Dialog)
                .WithMany(dialog => dialog.DialogTexts)
                .HasForeignKey(dialogTxt => dialogTxt.DialogId)
                .IsRequired()
                .HasConstraintName("FK_DialogText_Dialog");
        }
    }
}
