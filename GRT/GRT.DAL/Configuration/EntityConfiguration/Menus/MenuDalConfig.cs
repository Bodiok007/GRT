using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Menus
{
    public sealed class MenuDalConfig : EntityMappingConfiguration<MenuDal>
    {
        public override void Map(EntityTypeBuilder<MenuDal> builder)
        {
            builder
                .HasOne(menu => menu.Submenu)
                .WithOne();

            builder
                .HasOne(menu => menu.Project)
                .WithMany(proj => proj.Menus)
                .HasForeignKey(menu => menu.ProjectId)
                .IsRequired()
                .HasConstraintName("FK_Menu_Project");
        }
    }
}
