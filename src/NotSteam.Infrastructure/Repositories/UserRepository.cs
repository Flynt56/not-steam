﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Interfaces.Entities;

namespace NotSteam.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly NotSteamContext Context;

        public UserRepository(NotSteamContext context)
        {
            Context = context;
        }

        public async Task<IUser> GetByEmailAsync(string email)
        {
            return await Context.Users
                .Where(u => u.Email == email)
                .FirstAsync();
        }
    }
}
