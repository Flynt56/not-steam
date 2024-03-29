﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class LibraryEntityConfiguration : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            builder.HasKey(l => new { l.UserId, l.GameId });

            builder.HasOne(l => l.Game)
                .WithMany(g => g.Libraries)
                .HasForeignKey(l => l.GameId);

            builder.HasOne(l => l.User)
                .WithMany(u => u.Libraries)
                .HasForeignKey(l => l.UserId);

            builder.Property(l => l.DateAcquired)
                .IsRequired();

            builder.SetupSoftDelete();
        }
    }
}
