using AutoMapper;
using NotSteam.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Models;
using System;

namespace NotSteam.ViewModels
{
    public class UsersList : IHaveCustomMapping
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<User, UsersList>()
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Username))
                .ForMember(uDTO => uDTO.Nick, opt => opt.MapFrom(u => u.Nickname))
                .ForMember(uDTO => uDTO.Email, opt => opt.MapFrom(u => u.Email))
                .ForMember(uDTO => uDTO.DateOfBirth, opt => opt.MapFrom(u => u.DateOfBirth));
        }
    }
}
