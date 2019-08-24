using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Commands.UpdateGame
{
    public class UpdateGameDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BasePrice { get; set; }
        public int CompanyId { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, UpdateGameDto>()
                .ReverseMap();
        }
    }
}
