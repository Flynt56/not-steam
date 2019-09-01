using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Queries.GetGameEditForm
{
    public class CompanyListEntryDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Company, CompanyListEntryDto>()
                .ReverseMap();
        }
    }
}
