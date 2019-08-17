﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class LibraryQueryConfiguration : IQueryTypeConfiguration<Library>
    {
        public void Configure(QueryTypeBuilder<Library> builder)
        {
            builder.SetupSoftDelete();
        }
    }
}