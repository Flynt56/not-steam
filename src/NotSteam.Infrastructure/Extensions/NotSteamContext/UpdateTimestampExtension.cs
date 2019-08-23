using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NotSteam.Model.Interfaces;

namespace NotSteam.Core.Extensions.NotSteamContext
{
    public static class UpdateTimestampExtension
    {
        public static void UpdateTimestamp(this NotSteam.Infrastructure.DB.NotSteamContext context)
        {
            var entries = context.ChangeTracker.Entries();

            foreach (var entry in entries.Where(entry => entry.Entity is IEntityTimestamp).Select(entry => entry))
            {
                var entity = (IEntityTimestamp)entry.Entity;
                var now = DateTime.UtcNow;
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entity.UpdatedAt = now;
                        break;
                    case EntityState.Added:
                        entity.CreatedAt = now;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
