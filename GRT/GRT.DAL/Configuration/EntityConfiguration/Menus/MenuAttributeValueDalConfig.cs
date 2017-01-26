using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Menus
{
    public sealed class MenuAttributeValueDalConfig
        : EntityMappingConfiguration<MenuAttributeValueDal>
    {
        public override void Map(EntityTypeBuilder<MenuAttributeValueDal> builder)
        {
            //builder.HasKey(m => new { m.MenuId, m.MenuAttributeId });

            builder
                .HasOne(menuAttrVal => menuAttrVal.Menu)
                .WithMany(menu => menu.MenuAttributeValues)
                .HasForeignKey(menuAttrVal => menuAttrVal.MenuId)
                .IsRequired()
                .HasConstraintName("FK_MenuAttributeValue_Menu");

            builder
                .HasOne(menuAttrVal => menuAttrVal.MenuAttribute)
                .WithMany(menuAttr => menuAttr.MenuAttributeValues)
                .HasForeignKey(menuAttrVal => menuAttrVal.MenuAttributeId)
                .IsRequired()
                .HasConstraintName("FK_MenuAttributeValue_MenuAttribute");
        }
    }
}
