using System;
using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Levels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRT.DAL.Configuration.EntityConfiguration.Levels
{
    public sealed class LevelTranslateDalConfig
        : EntityMappingConfiguration<LevelTranslateDal>
    {
        public override void Map(EntityTypeBuilder<LevelTranslateDal> builder)
        {
            builder.HasKey(lvlTransl => new { lvlTransl.LevelId, lvlTransl.LanguageId });

            builder
                .HasOne(lvlTransl => lvlTransl.Level)
                .WithMany(lvl => lvl.LevelTranslates)
                .HasForeignKey(lvlTransl => lvlTransl.LevelId)
                .IsRequired()
                .HasConstraintName("FK_LevelTranslate_Level");

            builder
                .HasOne(lvlTransl => lvlTransl.Language)
                .WithMany(language => language.LevelTranslates)
                .HasForeignKey(lvlTransl => lvlTransl.LanguageId)
                .IsRequired()
                .HasConstraintName("FK_LevelTranslate_Language");
        }
    }
}
