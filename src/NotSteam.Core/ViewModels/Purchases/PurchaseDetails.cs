using System;
using System.Linq.Expressions;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class PurchaseDetails : IHaveCustomMapping
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        public string User { get; set; }
        public string Game { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Purchase, PurchaseDetails>()
                .ForMember(pDTO => pDTO.Date, opt => opt.MapFrom(p => p.DateOfPurchase));

            configuration.CreateMap<PurchaseDetails, Purchase>()
                .ForMember(p => p.DateOfPurchase, opt => opt.MapFrom(pDTO => pDTO.Date));
        }
    }
}
