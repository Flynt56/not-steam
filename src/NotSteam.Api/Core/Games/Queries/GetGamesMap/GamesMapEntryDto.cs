using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Api.Core.Games.Queries.GetGamesMap
{
    public class GamesMapEntryDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GamesMapEntryDto>()
                .ReverseMap();
        }
    }
}
