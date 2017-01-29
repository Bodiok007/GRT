using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Levels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Configuration.EntityConfiguration.Levels
{
    public sealed class LevelDalConfig
        : EntityMappingConfiguration<LevelDal>
    {
        public override void Map(EntityTypeBuilder<LevelDal> builder)
        {
            builder
                .HasOne(lvl => lvl.Project)
                .WithMany(proj => proj.Levels)
                .HasForeignKey(lvl => lvl.ProjectId)
                .IsRequired()
                .HasConstraintName("FK_Level_Project");
        }
    }
}
