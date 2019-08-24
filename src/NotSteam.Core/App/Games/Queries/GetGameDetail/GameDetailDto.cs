﻿using System;
using System.Linq;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Games.Queries.GetGameDetail
{
    public class GameDetailDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BasePrice { get; set; }

        public string CompanyName { get; set; }
        public int ReviewAmount { get; set; }
        public decimal AverageReview { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Game, GameDetailDto>()
                .ForMember(DTO => DTO.CompanyName, opt => opt.MapFrom(g => g.Company.Name))
                .ForMember(DTO => DTO.ReviewAmount, opt => opt.MapFrom(g => g.Reviews.Count))
                .ForMember(DTO => DTO.AverageReview, opt => opt.MapFrom(g => g.Reviews.Average(r => r.Rating)))
                .ReverseMap();
        }
    }
}
