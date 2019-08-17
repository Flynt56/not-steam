using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.HasIndex(u => u.Username)
                .IsUnique();

            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(32);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(32);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(254);

            builder.Property(u => u.Nickname)
                .HasMaxLength(32);

            builder.Property(u => u.DateOfBirth)
                .IsRequired();

            builder.SetupSoftDelete();
        }
    }
}
