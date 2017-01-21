using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Menus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration
{
    public sealed class MenuDalConfiguration : EntityMappingConfiguration<MenuDal>
    {
        public override void Map(EntityTypeBuilder<MenuDal> builder)
        {
            builder.HasKey(menu => menu.Id);
            //builder.HasOne(menu => menu.Submenu);
        }
    }
}
