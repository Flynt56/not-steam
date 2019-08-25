using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class GamesPageEntryDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BasePrice { get; set; }

        public IReadOnlyList<string> Tags { get; set; } = new List<string>();

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GamesPageEntryDto>()
                .ForMember(gDTO => gDTO.Tags, opt => opt.MapFrom(g => g.GameTags.Select(gt => gt.Tag.Name).ToList()))
                .ReverseMap();
        }
    }
}
