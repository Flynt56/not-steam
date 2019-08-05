using AutoMapper;
using NotSteam.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotSteam.ViewModels
{
    public class GamesList : IHaveCustomMapping
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BasePrice { get; set; }
        public ICollection<string> Tags { get; set; } = new HashSet<string>();

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GamesList>()
                .ForMember(gDTO => gDTO.Title, opt => opt.MapFrom(g=>g.Title))
                .ForMember(gDTO => gDTO.ReleaseDate, opt=>opt.MapFrom(g=>g.ReleaseDate))
                .ForMember(gDTO => gDTO.BasePrice, opt=>opt.MapFrom(g=>g.BasePrice))
                .ForMember(gDTO=>gDTO.Tags,opt=>opt.MapFrom(g=>g.GameTags.Select(gt => gt.Tag.Name).ToHashSet()));
        }
    }
}
