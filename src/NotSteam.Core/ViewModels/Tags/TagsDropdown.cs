using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class TagsDropdown : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagsDropdown>()
                .ForMember(tDTO => tDTO.Id, opt => opt.MapFrom(t => t.Id))
                .ForMember(tDTO => tDTO.Name, opt => opt.MapFrom(t => t.Name));
        }
    }
}
