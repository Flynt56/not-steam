using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Services;

namespace NotSteam.Core.App.Auth.Login.Command
{
    public class LoginRequestHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public LoginRequestHandler(IAuthService authService, IUserService userService, IMapper mapper)
        {
            _authService = authService;
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            string token = await _authService.SignInAsync(request.Email, request.Password);

            if (string.IsNullOrEmpty(token))
            {
                throw new ApplicationException("INVALID_LOGIN_ATTEMPT");
            }

            var authUserResponse = _mapper.Map<AuthUserResponse>(await _userService.GetByEmailAsync(request.Email));

            return new LoginResponse
            {
                Token = token,
                User = authUserResponse
            };
        }
    }
}
