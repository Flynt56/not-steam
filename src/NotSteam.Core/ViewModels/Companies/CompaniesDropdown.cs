﻿using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels.Companies
{
    public class CompaniesDropdown : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Company, CompaniesDropdown>()
                .ReverseMap();
        }
    }
}
