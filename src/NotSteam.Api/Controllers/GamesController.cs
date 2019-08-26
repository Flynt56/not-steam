﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Core.App.Games.Commands.AddGame;
using NotSteam.Core.App.Games.Commands.DeleteGame;
using NotSteam.Core.App.Games.Commands.UpdateGame;
using NotSteam.Core.App.Games.Queries.GetGameDetail;
using NotSteam.Core.App.Games.Queries.GetGamesMap;
using NotSteam.Core.App.Games.Queries.GetGamesPage;

namespace NotSteam.Core.Controllers
{
    public class GamesController : AppController
    {
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] GetGamesPageRequest request = null)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne([FromRoute] GetGameDetailRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await Mediator.Send(new GetGamesMapRequest()));
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
