using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class GameTagQueryConfiguration : IQueryTypeConfiguration<GameTag>
    {
        public void Configure(QueryTypeBuilder<GameTag> builder)
        {
            builder.SetupSoftDelete();
        }
    }
}
