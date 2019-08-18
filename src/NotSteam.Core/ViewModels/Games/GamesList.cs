using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels.Games
{
    public class GamesList : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BasePrice { get; set; }

        public ICollection<string> Tags { get; set; } = new HashSet<string>();

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GamesList>()
                .ForMember(gDTO => gDTO.Tags, opt => opt.MapFrom(g => g.GameTags.Select(gt => gt.Tag.Name).ToHashSet()))
                .ReverseMap();
        }
    }
}
