using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;
using System;

namespace NotSteam.Core.ViewModels
{
    public class LibrariesList : IHaveCustomMapping
    {
        public string OwnerUsername { get; set; }
        public string GameTitle { get; set; }
        public DateTime DateAcquired { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Library, LibrariesList>()
                .ForMember(lDTO => lDTO.OwnerUsername, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(lDTO => lDTO.GameTitle, opt => opt.MapFrom(g => g.Game.Title))
                .ForMember(lDTO => lDTO.DateAcquired, opt => opt.MapFrom(l => l.DateAcquired));
        }
    }
}
