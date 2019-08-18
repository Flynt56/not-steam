using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Api.Responses
{
    public class UserPaginationResponse : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<User, UserPaginationResponse>()
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Username))
                .ForMember(uDTO => uDTO.Nick, opt => opt.MapFrom(u => u.Nickname))
                .ForMember(uDTO => uDTO.DOB, opt => opt.MapFrom(u => u.DateOfBirth))
                .ReverseMap();
        }
    }
}
