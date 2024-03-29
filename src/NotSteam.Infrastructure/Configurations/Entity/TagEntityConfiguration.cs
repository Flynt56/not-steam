﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class TagEntityConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasIndex(t => t.Name)
                .IsUnique();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(48);

            builder.Property(t => t.Description)
                .HasMaxLength(250);

            builder.SetupSoftDelete();
        }
    }
}
