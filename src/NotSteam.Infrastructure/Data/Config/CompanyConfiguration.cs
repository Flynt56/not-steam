using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Entities;

namespace NotSteam.Infrastructure.Data.Config
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(c => c.HomepageUri)
                .IsRequired(false);

            builder.Property(c => c.LogoImageId)
                .IsRequired(false);

            builder.Property(c => c.Description)
                .HasMaxLength(1500);

            builder.SetupSoftDelete();
        }
    }
}
