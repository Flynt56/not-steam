using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class ReviewQueryConfiguration : IQueryTypeConfiguration<Review>
    {
        public void Configure(QueryTypeBuilder<Review> builder)
        {
            builder.SetupSoftDelete();
        }
    }
}
