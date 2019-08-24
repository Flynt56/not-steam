using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Api.ViewModels.Libraries
{
    public class LibrariesList : IHaveCustomMapping
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        public string OwnerUsername { get; set; }
        public string GameTitle { get; set; }
        public DateTime DateAcquired { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Library, LibrariesList>()
                .ForMember(lDTO => lDTO.OwnerUsername, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(lDTO => lDTO.GameTitle, opt => opt.MapFrom(g => g.Game.Title))
                .ReverseMap();
        }
    }
}
