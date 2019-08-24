using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Auth
{
    public class AuthUserResponse : IHaveCustomMapping
    {
        public string Id { get; set; }
        public string Email { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AuthUserResponse, AuthUser>()
                .ReverseMap();
        }
    }
}
