using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Model.Entities;
using NotSteam.Model.Interfaces;

namespace NotSteam.Infrastructure.Extensions
{
    public static class SoftDeleteSetupExtension
    {
        public static void SetupSoftDelete<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : ModelBase
        {
            if (typeof(IEntitySoftDelete).GetTypeInfo().IsAssignableFrom(typeof(TEntity).Ge‌​tTypeInfo()))
            {
                builder.HasQueryFilter(a => !((IEntitySoftDelete)a).IsDeleted);
            }
        }
    }
}
