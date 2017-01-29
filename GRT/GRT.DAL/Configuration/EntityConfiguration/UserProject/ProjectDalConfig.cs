using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.UserProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.UserProject
{
    public sealed class ProjectDalConfig : EntityMappingConfiguration<ProjectDal>
    {
        public override void Map(EntityTypeBuilder<ProjectDal> builder)
        {
            builder.HasOne(proj => proj.Owner)
                .WithMany(user => user.Projects)
                .HasForeignKey(proj => proj.OwnerId)
                .IsRequired()
                .HasConstraintName("FK_Project_User");
        }
    }
}
