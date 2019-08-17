using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class TagQueryConfiguration : IQueryTypeConfiguration<Tag>
    {
        public void Configure(QueryTypeBuilder<Tag> builder)
        {
            builder.SetupSoftDelete();
        }
    }
}
