using AutoMapper;

namespace NotSteam.Infrastructure.AutoMapper.Interfaces
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
