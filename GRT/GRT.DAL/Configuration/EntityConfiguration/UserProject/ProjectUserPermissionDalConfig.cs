using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.UserProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.DAL.Configuration.EntityConfiguration.UserProject
{
    public sealed class ProjectUserPermissionDalConfig : EntityMappingConfiguration<UserProjectPermissionDal>
    {
        public override void Map(EntityTypeBuilder<UserProjectPermissionDal> builder)
        {
            builder.HasKey(
                userProjPerm => new
                {
                    userProjPerm.UserId,
                    userProjPerm.ProjetId,
                    userProjPerm.PermissionId
                });

            builder.HasOne(userProjPerm => userProjPerm.User)
                .WithMany(user => user.UserProjectPermissions)
                .HasForeignKey(userProjPerm => userProjPerm.UserId)
                .IsRequired()
                .HasConstraintName("FK_UserProjectPermission_User").OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(userProjPerm => userProjPerm.Project)
                .WithMany(project => project.UserProjectPermissions)
                .HasForeignKey(userProjPerm => userProjPerm.ProjetId)
                .IsRequired()
                .HasConstraintName("FK_UserProjectPermission_Project");

            builder.HasOne(userProjPerm => userProjPerm.Permission)
                .WithMany(permission => permission.UserProjectPermissions)
                .HasForeignKey(userProjPerm => userProjPerm.PermissionId)
                .IsRequired()
                .HasConstraintName("FK_UserProjectPermission_Permission");
        }
    }
}
