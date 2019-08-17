using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;

namespace NotSteam.Core.ViewModels
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
                .ForMember(pDTO => pDTO.UserId, opt => opt.MapFrom(p => p.UserId))
                .ForMember(pDTO => pDTO.GameId, opt => opt.MapFrom(p => p.GameId))
                .ForMember(pDTO => pDTO.User, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(pDTO => pDTO.Game, opt => opt.MapFrom(g => g.Game.Title))
                .ForMember(pDTO => pDTO.TotalPrice, opt => opt.MapFrom(p => p.TotalPrice));
        }
    }
}
