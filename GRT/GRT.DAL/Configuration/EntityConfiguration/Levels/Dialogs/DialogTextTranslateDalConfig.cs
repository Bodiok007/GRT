using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Levels.Dialogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Levels.Dialogs
{
    public class DialogTextTranslateDalConfig
        : EntityMappingConfiguration<DialogTextTranslateDal>
    {
        public override void Map(EntityTypeBuilder<DialogTextTranslateDal> builder)
        {
            builder.HasKey(dialogTxtTransl => new { dialogTxtTransl.DialogTextId, dialogTxtTransl.LanguageId });

            builder
                .HasOne(dialogTxtTransl => dialogTxtTransl.DialogText)
                .WithMany(dialogTxt => dialogTxt.DialogTextTranslates)
                .HasForeignKey(dialogTxtTransl => dialogTxtTransl.DialogTextId)
                .IsRequired()
                .HasConstraintName("FK_DialogTextTranslate_DialogText");

            builder
                .HasOne(dialogTxtTransl => dialogTxtTransl.Language)
                .WithMany(language => language.DialogTextTranslates)
                .HasForeignKey(dialogTxtTransl => dialogTxtTransl.LanguageId)
                .IsRequired()
                .HasConstraintName("FK_DialogTextTranslate_Language");
        }
    }
}
