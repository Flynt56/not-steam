using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Companies.Queries.GetPaginatedCompaniesList
{
    public class CompaniesListEntryDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Company, CompaniesListEntryDto>()
                .ReverseMap();
        }
    }
}
