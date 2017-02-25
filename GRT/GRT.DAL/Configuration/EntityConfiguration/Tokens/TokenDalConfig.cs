using GRT.DAL.Configuration.MappingConfiguration;
using GRT.DAL.Models.Tokens;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GRT.DAL.Configuration.EntityConfiguration.Tokens
{
    public class TokenDalConfig : EntityMappingConfiguration<TokenDal>
    {
        public override void Map(EntityTypeBuilder<TokenDal> builder)
        {
            builder.HasOne(token => token.User)
                   .WithMany(user => user.Tokens)
                   .HasForeignKey(token => token.UserId)
                   .IsRequired(true)
                   .HasConstraintName("FK_Token_User");  
        }
    }
}
