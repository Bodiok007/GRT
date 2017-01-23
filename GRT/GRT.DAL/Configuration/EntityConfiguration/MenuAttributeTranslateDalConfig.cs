using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GRT.DAL.Configuration.EntityConfiguration
{
    public sealed class MenuAttributeTranslateDalConfig
        : EntityMappingConfiguration<MenuAttributeTranslateDal>
    {
        public override void Map(EntityTypeBuilder<MenuAttributeTranslateDal> builder)
        {
            builder.HasKey(menuAttrTransl => new { menuAttrTransl.MenuAttributeId, menuAttrTransl.LanguageId });

            builder
                .HasOne(menuAttrTransl => menuAttrTransl.MenuAttribute)
                .WithMany(menuAttr => menuAttr.MenuAttributes)
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
