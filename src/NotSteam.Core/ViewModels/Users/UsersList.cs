using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class UsersList : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<User, UsersList>()
                .ForMember(uDTO => uDTO.Id, opt => opt.MapFrom(u => u.Id))
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Username))
                .ForMember(uDTO => uDTO.Nick, opt => opt.MapFrom(u => u.Nickname))
                .ForMember(uDTO => uDTO.Email, opt => opt.MapFrom(u => u.Email))
                .ForMember(uDTO => uDTO.DateOfBirth, opt => opt.MapFrom(u => u.DateOfBirth));
        }
    }
}
