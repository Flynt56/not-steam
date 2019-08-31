using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Api.Core.Auth;
using NotSteam.Core.Interfaces.Services;

namespace NotSteam.Api.Core.Auth.Register.Command
{
    public class RegisterRequestHandler : IRequestHandler<RegisterRequest, RegisterResponse>
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public RegisterRequestHandler(IAuthService authService, IUserService userService, IMapper mapper)
        {
            _authService = authService;
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<RegisterResponse> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.RegisterAsync(request.Email, request.Password);

            if (string.IsNullOrEmpty(token))
            {
                throw new ApplicationException("UNKNOWN_ERROR");
            }

            var authUserResponse = _mapper.Map<AuthUserResponse>(await _userService.GetByEmailAsync(request.Email));

            return new RegisterResponse
            {
                Token = token,
                User = authUserResponse
            };
        }
    }
}
