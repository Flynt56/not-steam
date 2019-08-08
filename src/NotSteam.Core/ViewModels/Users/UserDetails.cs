using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class UserDetails : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<User, UserDetails>()
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Username))
                .ForMember(uDTO => uDTO.Nick, opt => opt.MapFrom(u => u.Nickname))
                .ForMember(uDTO => uDTO.DOB, opt => opt.MapFrom(u => u.DateOfBirth));
        }
    }
}
