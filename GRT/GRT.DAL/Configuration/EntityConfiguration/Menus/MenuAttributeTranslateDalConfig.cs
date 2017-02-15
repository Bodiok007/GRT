using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Menus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Configuration.EntityConfiguration.Menus
{
    public sealed class MenuAttributeTranslateDalConfig
        : EntityMappingConfiguration<MenuAttributeTranslateDal>
    {
        public override void Map(EntityTypeBuilder<MenuAttributeTranslateDal> builder)
        {
            builder.HasKey(menuAttrTransl => new { menuAttrTransl.MenuAttributeId, menuAttrTransl.LanguageId });

            builder
                .HasOne(menuAttrTransl => menuAttrTransl.MenuAttribute)
                .WithMany(menuAttr => menuAttr.MenuAttributeTranslates)
                .HasForeignKey(menuAttrVal => menuAttrVal.MenuAttributeId)
                .IsRequired()
                .HasConstraintName("FK_MenuAttributeTranslate_MenuAttribute");

            builder
                .HasOne(menuAttrVal => menuAttrVal.Language)
                .WithMany(language => language.MenuAttributeTranslates)
                .HasForeignKey(menuAttrVal => menuAttrVal.LanguageId)
                .IsRequired()
                .HasConstraintName("FK_MenuAttributeTranslate_Language");
        }
    }
}
