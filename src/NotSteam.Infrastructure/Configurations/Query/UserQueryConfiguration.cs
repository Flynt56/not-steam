﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class UserQueryConfiguration : IQueryTypeConfiguration<User>
    {
        public void Configure(QueryTypeBuilder<User> builder)
        {
            builder.SetupSoftDelete();
        }
    }
}