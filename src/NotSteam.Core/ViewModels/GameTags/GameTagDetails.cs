using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels
{
    public class GameTagDetails : IHaveCustomMapping
    {
        public int GameId { get; set; }
        public int TagId { get; set; }

        public string TagName { get; set; }
        public string GameTitle { get; set; }
        public DateTime DateAdded { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<GameTag, GameTagDetails>()
                .ForMember(gtDTO => gtDTO.TagName, opt => opt.MapFrom(gt => gt.Tag.Name))
                .ForMember(gtDTO => gtDTO.GameTitle, opt => opt.MapFrom(gt => gt.Game.Title))
                .ForMember(gtDTO => gtDTO.DateAdded, opt => opt.MapFrom(gt => gt.CreatedAt));

            configuration.CreateMap<GameTagDetails, GameTag>();
        }
    }
}
