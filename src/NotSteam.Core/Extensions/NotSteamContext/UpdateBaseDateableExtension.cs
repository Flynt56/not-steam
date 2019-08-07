using Microsoft.EntityFrameworkCore;
using NotSteam.Models.Interfaces;
using System;
using System.Linq;

namespace NotSteam.Extensions.NotSteamContext
{
    public static class UpdateBaseDateableExtension
    {
        public static void UpdateBaseDateable(this DB.NotSteamContext context)
        {
            var entries = context.ChangeTracker.Entries();
            foreach (var entry in entries.Where(entry => entry.Entity is IBaseDateable).Select(entry => entry))
            {
                var entity = (IBaseDateable)entry.Entity;
                var now = DateTime.UtcNow;
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entity.LastModifiedAt = now;
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

