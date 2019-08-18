using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels.Reviews
{
    public class ReviewsList : IHaveCustomMapping
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        public string User { get; set; }
        public string Game { get; set; }
        public int Rating { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Review, ReviewsList>()
                .ForMember(rDTO => rDTO.User, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(rDTO => rDTO.Game, opt => opt.MapFrom(g => g.Game.Title))
                .ReverseMap();
        }
    }
}
