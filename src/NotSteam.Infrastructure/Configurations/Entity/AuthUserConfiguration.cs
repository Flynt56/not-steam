using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Identity;

namespace NotSteam.Infrastructure.Configurations.Entity
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
