using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Services;

namespace NotSteam.Api.Identity.Auth.Login.Command
{
    public class LoginRequestHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IAuthService _authService;
        private readonly IAuthUserService _authUserService;
        private readonly IMapper _mapper;

        public LoginRequestHandler(IAuthService authService, IAuthUserService authUserService, IMapper mapper)
        {
            _authService = authService;
            _authUserService = authUserService;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.SignInAsync(request.Email, request.Password);

            if (string.IsNullOrEmpty(token))
            {
                throw new ApplicationException("INVALID_LOGIN_ATTEMPT");
            }

            var authUserResponse = _mapper.Map<AuthUserResponse>(await _authUserService.GetByEmailAsync(request.Email));

            return new LoginResponse
            {
                Token = token,
                User = authUserResponse
            };
        }
    }
}
