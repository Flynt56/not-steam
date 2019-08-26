using System.Threading.Tasks;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Model.Identity;

namespace NotSteam.Core.Services
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
