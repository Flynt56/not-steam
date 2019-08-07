using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class CompaniesList : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Company, CompaniesList>()
                .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.Id))
                .ForMember(uDTO => uDTO.Name, opt => opt.MapFrom(u => u.Name))
                .ForMember(uDTO => uDTO.Description, opt => opt.MapFrom(u => u.Description));
        }
    }
}
