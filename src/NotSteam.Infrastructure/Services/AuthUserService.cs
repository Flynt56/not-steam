using System.Threading.Tasks;
using NotSteam.Infrastructure.Identity;
using NotSteam.Infrastructure.Interfaces.Repositories;
using NotSteam.Infrastructure.Interfaces.Services;

namespace NotSteam.Infrastructure.Services
{
    public class AuthUserService : IAuthUserService
    {
        private readonly IAuthUserRepository _authUserRepository;

        public AuthUserService(IAuthUserRepository authUserRepository)
        {
            _authUserRepository = authUserRepository;
        }

        public async Task<AuthUser> GetByEmailAsync(string email)
        {
            return await _authUserRepository.GetByEmailAsync(email);
        }
    }
}
