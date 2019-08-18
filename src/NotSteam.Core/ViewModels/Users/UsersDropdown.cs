using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.ViewModels
{
    public class UsersDropdown : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<User, UsersDropdown>()
                .ForMember(uDTO => uDTO.Id, opt => opt.MapFrom(u => u.Id))
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Username));
        }
    }
}
