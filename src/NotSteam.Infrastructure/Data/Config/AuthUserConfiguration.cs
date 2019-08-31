using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Model.Identity;

namespace NotSteam.Infrastructure.Data.Config
{
    public class AuthUserConfiguration : IEntityTypeConfiguration<AuthUser>
    {
        public void Configure(EntityTypeBuilder<AuthUser> builder)
        {
            builder.Property(u => u.Nickname)
                .HasMaxLength(32);

            builder.Property(u => u.DateOfBirth)
                .IsRequired();
        }
    }
}
