﻿using System.Threading.Tasks;

namespace NotSteam.Core.Interfaces.Services
{
    public interface IAuthService : IAppService
    {
        Task<string> SignInAsync(string email, string password);
        Task<string> RegisterAsync(string email, string password);
    }
}
