using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Entities;

namespace NotSteam.Infrastructure.Data.Config
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(p => new { p.UserId, p.GameId });

            builder.HasOne(p => p.Game)
                .WithMany(g => g.Purchases)
                .HasForeignKey(p => p.GameId);

            builder.HasOne(p => p.User)
                .WithMany(u => u.Purchases)
                .HasForeignKey(p => p.UserId);

            builder.Property(p => p.DateOfPurchase)
                .IsRequired();

            builder.Property(p => p.TotalPrice)
                .HasColumnType("decimal(19,4)")
                .IsRequired();

            builder.SetupSoftDelete();
        }
    }
}
