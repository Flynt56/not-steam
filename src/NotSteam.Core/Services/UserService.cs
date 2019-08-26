using System.Threading.Tasks;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Model.Interfaces.Entities;

namespace NotSteam.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IUser> GetByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }
    }
}
