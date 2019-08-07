using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;
using System;

namespace NotSteam.Core.ViewModels
{
    public class TagsList : IHaveCustomMapping
    {
        public string Name { get; set; }
        public int UsageAmount { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagsList>()
                .ForMember(tDTO => tDTO.Name, opt => opt.MapFrom(t => t.Name))
                .ForMember(tDTO => tDTO.UsageAmount, opt => opt.MapFrom(t => t.GameTags.Count));
        }
    }
}
