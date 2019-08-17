using System;
using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;

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
        public string ProfileImageUri { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<User, UserDetails>(MemberList.Source)
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Username))
                .ForMember(uDTO => uDTO.Nick, opt => opt.MapFrom(u => u.Nickname))
                .ForMember(uDTO => uDTO.DOB, opt => opt.MapFrom(u => u.DateOfBirth));

            configuration.CreateMap<UserDetails, User>()
                .ForMember(u => u.Username, opt => opt.MapFrom(uDTO => uDTO.Name))
                .ForMember(u => u.Nickname, opt => opt.MapFrom(uDTO => uDTO.Nick))
                .ForMember(u => u.DateOfBirth, opt => opt.MapFrom(uDTO => uDTO.DOB));
        }
    }
}
