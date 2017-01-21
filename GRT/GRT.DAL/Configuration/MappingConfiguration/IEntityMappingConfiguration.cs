using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.MappingConfiguration
{
    public interface IEntityMappingConfiguration
    {
        void Map(ModelBuilder modelBuilder);
    }

    public interface IEntityMappingConfiguration<T> : IEntityMappingConfiguration where T : class
    {
        void Map(EntityTypeBuilder<T> builder);
    }
}
