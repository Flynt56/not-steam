using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotSteam.Infrastructure.Extensions;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Configurations.Entity
{
    public class CompanyQueryConfiguration : IQueryTypeConfiguration<Company>
    {
        public void Configure(QueryTypeBuilder<Company> builder)
        {
            builder.SetupSoftDelete();
        }
    }
}
