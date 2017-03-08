using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.UserProject;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Configuration.EntityConfiguration.UserProject
{
    public sealed class UserDalConfig : EntityMappingConfiguration<UserDal>
    {
        public override void Map(EntityTypeBuilder<UserDal> builder)
        {
            builder.HasIndex(user => user.Login).IsUnique();
            builder.HasIndex(user => user.Email).IsUnique();
        }
    }
}
