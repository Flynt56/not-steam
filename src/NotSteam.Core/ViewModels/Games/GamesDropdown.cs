using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels.Games
{
    public class GamesDropdown : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GamesDropdown>().ReverseMap();
        }
    }
}
