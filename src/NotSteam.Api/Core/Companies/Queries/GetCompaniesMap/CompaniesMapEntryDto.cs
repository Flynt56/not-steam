using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Companies.Queries.GetCompaniesMap
{
    public class CompaniesMapEntryDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Company, CompaniesMapEntryDto>()
                .ReverseMap();
        }
    }
}
