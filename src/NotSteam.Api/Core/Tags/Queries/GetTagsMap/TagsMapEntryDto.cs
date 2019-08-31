﻿using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Entities;

namespace NotSteam.Api.Core.Tags.Queries.GetTagsMap
{
    public class TagsMapEntryDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagsMapEntryDto>()
                .ReverseMap();
        }
    }
}
