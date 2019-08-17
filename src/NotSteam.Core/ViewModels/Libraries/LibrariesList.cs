using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;

namespace NotSteam.Core.ViewModels
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
                .ForMember(lDTO => lDTO.UserId, opt => opt.MapFrom(l => l.UserId))
                .ForMember(lDTO => lDTO.GameId, opt => opt.MapFrom(l => l.GameId))
                .ForMember(lDTO => lDTO.OwnerUsername, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(lDTO => lDTO.GameTitle, opt => opt.MapFrom(g => g.Game.Title))
                .ForMember(lDTO => lDTO.DateAcquired, opt => opt.MapFrom(l => l.DateAcquired));
        }
    }
}
