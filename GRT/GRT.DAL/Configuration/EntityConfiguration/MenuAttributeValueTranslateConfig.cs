using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Menus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Configuration.EntityConfiguration
{
    public sealed class MenuAttributeValueTranslateConfig 
        : EntityMappingConfiguration<MenuAttributeValueTranslateDal>
    {
        public override void Map(EntityTypeBuilder<MenuAttributeValueTranslateDal> builder)
        {
            builder.HasKey(
                menuAttrValTransl => new
                {
                    menuAttrValTransl.MenuAttributeValueId,
                    menuAttrValTransl.LanguageId
                });

            builder
                .HasOne(menuAttrValTransl => menuAttrValTransl.MenuAttributeValue)
                .WithMany(menuAttrVal => menuAttrVal.MenuAttributeValueTranslates)
                .HasForeignKey(menuAttrValTransl => menuAttrValTransl.MenuAttributeValueId)
                .IsRequired()
                .HasConstraintName("FK_MenuAttributeValueTranslate_MenuAttributeValue");

            builder
                .HasOne(menuAttrValTransl => menuAttrValTransl.Language)
                .WithMany(language => language.MenuAttributeValueTranslates)
                .HasForeignKey(menuAttrValTransl => menuAttrValTransl.LanguageId)
                .IsRequired()
                .HasConstraintName("FK_MenuAttributeValueTranslate_Language");
        }
    }
}
