using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.App.Games.Commands.AddGame;
using NotSteam.Core.App.Games.Commands.DeleteGame;
using NotSteam.Core.App.Games.Commands.UpdateGame;
using NotSteam.Core.App.Games.Queries.GetGameDetail;
using NotSteam.Core.App.Games.Queries.GetGamesMap;
using NotSteam.Core.App.Games.Queries.GetPaginatedGamesList;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Shared.Extensions;

namespace NotSteam.Api.Controllers
{
    public class GamesController : AppController
    {
        private readonly IGameRepository GameRepository;
        private readonly IMapper Mapper;
        private readonly IGameService GameService;

        public GamesController(IGameService gameService, IGameRepository gameRepository, IMapper mapper)
        {
            GameService = gameService;
            GameRepository = gameRepository;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] GetGamesPageRequest request = null)
        {
            return ApiOk(await GameService.GetPageAsync(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne([FromQuery] GetGameDetailQuery query)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await Mediator.Send(new GetGamesMapQuery()));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOne(int id, [FromBody] UpdateGameDto game)
        {
            return ApiOk(await Mediator.Send(new UpdateGameCommand { Id = id, UpdateGameDto = game }));
        }

        [HttpPost]
        public async Task<IActionResult> PostOne([FromBody] AddGameDto game)
        {
            return ApiOk(await Mediator.Send(new AddGameCommand { AddGameDto = game }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOne([FromQuery] DeleteGameCommand command)
        {
            return ApiOk(await Mediator.Send(command));
        }
    }
}
