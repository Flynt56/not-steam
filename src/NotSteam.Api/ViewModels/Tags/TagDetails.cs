using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Api.ViewModels.Tags
{
    public class TagDetails : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int UsageAmount { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagDetails>()
                .ForMember(tDTO => tDTO.UsageAmount, opt => opt.MapFrom(t => t.GameTags.Count))
                .ReverseMap();
        }
    }
}
