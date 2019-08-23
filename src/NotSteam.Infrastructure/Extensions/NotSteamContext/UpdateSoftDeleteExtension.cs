using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NotSteam.Model.Interfaces;

namespace NotSteam.Core.Extensions.NotSteamContext
{
    public static class UpdateSoftDeleteExtension
    {
        public static void UpdateSoftDelete(this NotSteam.Infrastructure.DB.NotSteamContext context)
        {
            var entries = context.ChangeTracker.Entries();

            foreach (var entry in entries
                .Where(entry => entry.Entity is IEntitySoftDelete)
                .Select(entry => entry))
            {
                var entity = (IEntitySoftDelete)entry.Entity;
                var now = DateTime.UtcNow;

                switch (entry.State)
                {
                    case EntityState.Added:
                        entity.DeletedAt = null;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entity.DeletedAt = now;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
