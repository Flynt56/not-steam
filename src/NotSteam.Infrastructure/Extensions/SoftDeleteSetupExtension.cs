using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Model.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Extensions
{
    public static class SoftDeleteSetupExtension
    {
        public static void SetupSoftDelete<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : BaseModel
        {
            if (typeof(ISoftDeletable).GetTypeInfo().IsAssignableFrom(typeof(TEntity).Ge‌​tTypeInfo()))
            {
                builder.HasQueryFilter(a => !((ISoftDeletable)a).IsDeleted);
            }
        }
    }
}
