using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class GameQueryConfiguration : IQueryTypeConfiguration<Game>
    {
        public void Configure(QueryTypeBuilder<Game> builder)
        {
            builder.SetupSoftDelete();
        }
    }
}
