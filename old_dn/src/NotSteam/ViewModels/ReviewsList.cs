using AutoMapper;
using NotSteam.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Models;
using System;

namespace NotSteam.ViewModels
{
    public class ReviewsList : IHaveCustomMapping
    {
        public string User { get; set; }
        public string Game { get; set; }
        public int Rating { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Review, ReviewsList>()
                .ForMember(rDTO => rDTO.User, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(rDTO => rDTO.Game, opt => opt.MapFrom(g => g.Game.Title))
                .ForMember(rDTO => rDTO.Rating, opt => opt.MapFrom(r => r.Rating));
        }
    }
}
