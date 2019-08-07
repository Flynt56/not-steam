using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class GamesDropdown : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GamesDropdown>()
                .ForMember(gDTO => gDTO.Id, opt => opt.MapFrom(g => g.Id))
                .ForMember(gDTO => gDTO.Title, opt => opt.MapFrom(g => g.Title));
        }
    }
}
