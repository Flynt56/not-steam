using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class TagDetails : IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int UsageAmount { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Tag, TagDetails>();
            configuration.CreateMap<TagDetails, Tag>();
        }
    }
}
