using System.Reflection;
using NotSteam.Core.Models;
using NotSteam.Core.Models.Interfaces;

namespace NotSteam.Core.Extensions.ModelBuilder
{
    public static class SoftDeleteSetupExtension
    {
        public static void SoftDeleteSetup(this Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            SetupQueryFilter<User>(modelBuilder);
            SetupQueryFilter<Game>(modelBuilder);
            SetupQueryFilter<Company>(modelBuilder);
            SetupQueryFilter<Tag>(modelBuilder);

            SetupQueryFilter<GameTag>(modelBuilder);
            SetupQueryFilter<Purchase>(modelBuilder);
            SetupQueryFilter<Review>(modelBuilder);
            SetupQueryFilter<Library>(modelBuilder);
        }

        private static void SetupQueryFilter<TEntity>(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
            where TEntity : class
        {
            if (typeof(ISoftDeletable).GetTypeInfo().IsAssignableFrom(typeof(TEntity).Ge‌​tTypeInfo()))
            {
                modelBuilder.Entity<TEntity>().HasQueryFilter(temp => !((ISoftDeletable)temp).IsDeleted);
            }
        }
    }
}

