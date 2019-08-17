using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class CompanyEntityConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(c => c.Description)
                .HasMaxLength(1500);
        }
    }
}
