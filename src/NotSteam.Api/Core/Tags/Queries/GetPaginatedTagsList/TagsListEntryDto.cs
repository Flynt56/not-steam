using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Entities;

namespace NotSteam.Api.Core.Tags.Queries.GetPaginatedTagsList
{
    public class TagsListEntryDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int UsageAmount { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagsListEntryDto>()
                .ForMember(tDTO => tDTO.UsageAmount, opt => opt.MapFrom(t => t.GameTags.Count))
                .ReverseMap();
        }
    }
}
