using AutoMapper;
using NotSteam.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Models;
using System;

namespace NotSteam.ViewModels
{
    public class PurchasesList : IHaveCustomMapping
    {
        public string User { get; set; }
        public string Game { get; set; }
        public decimal TotalPrice { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Purchase, PurchasesList>()
                .ForMember(pDTO => pDTO.User, opt => opt.MapFrom(u => u.User.Username))
                .ForMember(pDTO => pDTO.Game, opt => opt.MapFrom(g => g.Game.Title))
                .ForMember(pDTO => pDTO.TotalPrice, opt => opt.MapFrom(p => p.TotalPrice));
        }
    }
}
