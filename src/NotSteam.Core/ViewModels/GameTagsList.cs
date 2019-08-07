using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class GameTagsList : IHaveCustomMapping
    {
        public string TagName { get; set; }
        public string GameTitle { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<GameTag, GameTagsList>()
                .ForMember(gtDTO => gtDTO.TagName, opt => opt.MapFrom(gt => gt.Tag.Name))
                .ForMember(gtDTO => gtDTO.GameTitle, opt => opt.MapFrom(gt => gt.Game.Title));
        }
    }
}
