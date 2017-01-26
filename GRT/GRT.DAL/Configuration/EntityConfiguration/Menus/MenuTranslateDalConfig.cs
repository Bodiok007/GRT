using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Menus
{
    public sealed class MenuTranslateDalConfig : EntityMappingConfiguration<MenuTranslateDal>
    {
        public override void Map(EntityTypeBuilder<MenuTranslateDal> builder)
        {
            builder.HasKey(menu => new { menu.MenuId, menu.LanguageId });

            //builder.HasOne(menu => menu.Submenu);
            //builder.HasMany(menu => menu.Menus).

            builder.HasOne(memuTranslate => memuTranslate.Menu)
                .WithMany(memu => memu.MenuTranslates)
                .HasForeignKey(memuTranslate => memuTranslate.MenuId)
                .IsRequired()
                .HasConstraintName("FK_MenuTranslate_Menu");

            builder.HasOne(memuTranslate => memuTranslate.Language)
                .WithMany(language => language.MenuTranslates)
                .HasForeignKey(memuTranslate => memuTranslate.LanguageId)
                .IsRequired()
                .HasConstraintName("FK_MenuTranslate_Language");
        }
    }
}
