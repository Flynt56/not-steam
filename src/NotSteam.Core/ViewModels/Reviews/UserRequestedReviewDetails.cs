using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels
{
    public class UserRequestedReviewDetails : IHaveCustomMapping
    {
        public int GameId { get; set; }

        public int Rating { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Review, UserRequestedReviewDetails>();
        }
    }
}
