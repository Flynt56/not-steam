using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Tags.Queries.GetTagEditForm
{
    public class TagEditFormDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagEditFormDto>()
                .ReverseMap();
        }
    }
}
