using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Model.Identity.Models;

namespace NotSteam.Infrastructure.Data.Config
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(au => au.Nickname)
                .IsRequired(false)
                .HasMaxLength(32);

            builder.Property(au => au.DateOfBirth)
                .IsRequired();

            builder.Property(au => au.ProfileImageId)
                .IsRequired(false);
        }
    }
}
