using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Infrastructure.Repositories
{
    public class GameRepository : EfRepository<Game>, IGameRepository
    {
        public GameRepository(NotSteamContext dbContext) : base(dbContext)
        {
        }
    }
}
