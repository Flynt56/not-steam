using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Infrastructure.Interfaces.Services;

namespace NotSteam.Api.Identity.Auth.Register.Command
{
    public class RegisterRequestHandler : IRequestHandler<RegisterRequest, RegisterResponse>
    {
        private readonly IAuthService _authService;
        private readonly IAuthUserService _authUserService;
        private readonly IMapper _mapper;

        public RegisterRequestHandler(IAuthService authService, IAuthUserService authUserService, IMapper mapper)
        {
            _authService = authService;
            _authUserService = authUserService;
            _mapper = mapper;
        }

        public async Task<RegisterResponse> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.RegisterAsync(request.Email, request.Password);

            if (string.IsNullOrEmpty(token))
            {
                throw new ApplicationException("UNKNOWN_ERROR");
            }

            var authUserResponse = _mapper.Map<AuthUserResponse>(await _authUserService.GetByEmailAsync(request.Email));

            return new RegisterResponse
            {
                Token = token,
                User = authUserResponse
            };
        }
    }
}
