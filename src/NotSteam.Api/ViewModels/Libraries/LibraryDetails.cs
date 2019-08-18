using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels
{
    public class LibraryDetails : IHaveCustomMapping
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        public string OwnerUsername { get; set; }
        public string GameTitle { get; set; }
        public DateTime DateAcquired { get; set; }
        public int TotalPlayTimeHours { get; set; }
        public DateTime? LastPlayed { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Library, LibraryDetails>()
                .ReverseMap();

            /*
            configuration.CreateMap<LibraryDetails, Library>()
                .ForMember(l => l.Game, opt => opt.Ignore())
                .ForMember(l => l.User, opt => opt.Ignore());
            */
        }
    }
}
