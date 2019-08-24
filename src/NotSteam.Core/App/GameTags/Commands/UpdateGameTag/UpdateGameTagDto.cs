using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.GameTags.Commands.UpdateGameTag
{
    public class UpdateGameTagDto : IHaveCustomMapping
    {
        public int GameId { get; set; }
        public int TagId { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<GameTag, UpdateGameTagDto>()
                .ReverseMap();
        }
    }
}
