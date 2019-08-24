using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.DTOs.Games
{
    public class GamesDropdownEntry : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GamesDropdownEntry>()
                .ReverseMap();
        }
    }
}
