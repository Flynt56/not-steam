using System.Linq;
using Microsoft.EntityFrameworkCore;
using NotSteam.Model.Interfaces;

namespace NotSteam.Core.Extensions.NotSteamContext
{
    public static class UpdateSoftDeletableExtension
    {
        public static void UpdateSoftDeletable(this Infrastructure.DB.NotSteamContext context)
        {
            var entries = context.ChangeTracker.Entries();
            foreach (var entry in entries.Where(entry => entry.Entity is ISoftDeletable).Select(entry => entry))
            {
                var entity = (ISoftDeletable)entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        entity.IsDeleted = false;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entity.IsDeleted = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
