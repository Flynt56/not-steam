using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels
{
    public class ReviewDetails : IHaveCustomMapping
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        public string User { get; set; }
        public string Game { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Review, ReviewDetails>();

            configuration.CreateMap<ReviewDetails, Review>()
                .ForMember(r => r.User, opt => opt.Ignore())
                .ForMember(r => r.Game, opt => opt.Ignore());
        }
    }
}
