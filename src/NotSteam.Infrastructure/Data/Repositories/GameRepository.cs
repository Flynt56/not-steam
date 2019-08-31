using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Infrastructure.Data;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Data.Repositories
{
    public class GameRepository : EfRepository<Game>, IGameRepository
    {
        public GameRepository(NotSteamContext dbContext) : base(dbContext)
        {
        }
    }
}
