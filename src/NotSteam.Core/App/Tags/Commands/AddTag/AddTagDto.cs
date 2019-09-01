using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Tags.Commands.AddTag
{
    public class AddTagDto : IHaveCustomMapping
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, AddTagDto>()
                .ReverseMap();
        }
    }
}
