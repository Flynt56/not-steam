using AutoMapper;
using NotSteam.Core.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Infrastructure.Identity;

namespace NotSteam.Api.Identity.Auth
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
