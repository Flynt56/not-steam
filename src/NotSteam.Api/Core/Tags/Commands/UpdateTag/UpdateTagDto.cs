using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Entities;

namespace NotSteam.Api.Core.Tags.Commands.UpdateTag
{
    public class UpdateTagDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, UpdateTagDto>()
                .ReverseMap();
        }
    }
}
