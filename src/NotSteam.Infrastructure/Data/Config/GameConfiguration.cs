using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Entities;

namespace NotSteam.Infrastructure.Data.Config
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(g => g.Title)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(g => g.Description)
                .IsRequired(false)
                .HasMaxLength(1500);

            builder.Property(g => g.ReleaseDate)
                .IsRequired();

            builder.Property(g => g.BasePrice)
                .IsRequired()
                .HasColumnType("decimal(19,4)");

            builder.Property(g => g.CompanyId)
                .IsRequired();

            builder.Property(g => g.CoverArtId)
                .IsRequired(false);

            builder.SetupSoftDelete();
        }
    }
}
