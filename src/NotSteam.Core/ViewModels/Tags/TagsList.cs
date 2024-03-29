﻿using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels.Tags
{
    public class TagsList : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int UsageAmount { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagsList>()
                .ForMember(tDTO => tDTO.UsageAmount, opt => opt.MapFrom(t => t.GameTags.Count))
                .ReverseMap();
        }
    }
}
