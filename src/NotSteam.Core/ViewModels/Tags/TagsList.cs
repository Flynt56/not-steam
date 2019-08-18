using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels
{
    public class TagsList : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UsageAmount { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagsList>()
                .ForMember(tDTO => tDTO.Id, opt => opt.MapFrom(t => t.Id))
                .ForMember(tDTO => tDTO.Name, opt => opt.MapFrom(t => t.Name))
                .ForMember(tDTO => tDTO.UsageAmount, opt => opt.MapFrom(t => t.GameTags.Count));
        }
    }
}
