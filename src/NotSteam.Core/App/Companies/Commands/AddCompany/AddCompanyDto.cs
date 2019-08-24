using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Companies.Commands.AddCompany
{
    public class AddCompanyDto : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string HomepageUri { get; set; }
        public string LogoImageUri { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Company, AddCompanyDto>()
                .ReverseMap();
        }
    }
}
