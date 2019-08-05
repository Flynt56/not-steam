using AutoMapper;
using NotSteam.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Models;
using System;

namespace NotSteam.ViewModels
{
    public class CompaniesList : IHaveCustomMapping
    {
        public string Name { get; set; }
        public string Descripton { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Company, CompaniesList>()
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Name))
                .ForMember(uDTO => uDTO.Descripton, opt => opt.MapFrom(u => u.Description));
        }
    }
}
