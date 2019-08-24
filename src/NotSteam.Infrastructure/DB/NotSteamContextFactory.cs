﻿using Microsoft.EntityFrameworkCore;
using NotSteam.Infrastructure.DB.Infrastructure;

namespace NotSteam.Infrastructure.DB
{
    public class NorthwindDbContextFactory : DesignTimeDbContextFactoryBase<NotSteamContext>
    {
        protected override NotSteamContext CreateNewInstance(DbContextOptions<NotSteamContext> options)
        {
            return new NotSteamContext(options);
        }
    }
}