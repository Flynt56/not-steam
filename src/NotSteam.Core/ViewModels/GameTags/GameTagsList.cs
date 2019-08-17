using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;

namespace NotSteam.Core.ViewModels
{
    public class GameTagsList : IHaveCustomMapping
    {
        public int GameId { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string GameTitle { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<GameTag, GameTagsList>()
                .ForMember(gtDTO => gtDTO.GameId, opt => opt.MapFrom(gt => gt.GameId))
                .ForMember(gtDTO => gtDTO.TagId, opt => opt.MapFrom(gt => gt.TagId))
                .ForMember(gtDTO => gtDTO.TagName, opt => opt.MapFrom(gt => gt.Tag.Name))
                .ForMember(gtDTO => gtDTO.GameTitle, opt => opt.MapFrom(gt => gt.Game.Title));
        }
    }
}
