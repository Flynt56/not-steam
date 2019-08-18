using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels.Purchases
{
    public class PurchasesList : IHaveCustomMapping
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        public string User { get; set; }
        public string Game { get; set; }
        public decimal TotalPrice { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Purchase, PurchasesList>()
                .ForMember(pDTO => pDTO.User, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(pDTO => pDTO.Game, opt => opt.MapFrom(g => g.Game.Title))
                .ReverseMap();
        }
    }
}
