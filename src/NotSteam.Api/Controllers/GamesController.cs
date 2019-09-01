using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Core.App.Games.Commands.AddGame;
using NotSteam.Core.App.Games.Commands.DeleteGame;
using NotSteam.Core.App.Games.Commands.UpdateGame;
using NotSteam.Core.App.Games.Queries.GetGameAddForm;
using NotSteam.Core.App.Games.Queries.GetGameDetail;
using NotSteam.Core.App.Games.Queries.GetGameEditForm;
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

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> GetEditData([FromRoute] GetGameEditFormRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpGet("add")]
        public async Task<IActionResult> GetAddData([FromRoute] GetGameAddFormRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOne(int id, [FromBody] UpdateGameDto game)
        {
            return ApiOk(await Mediator.Send(new UpdateGameCommand { Id = id, Game = game }));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostOne([FromBody] AddGameDto game)
        {
            return ApiOk(await Mediator.Send(new AddGameCommand { Game = game }));
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOne([FromRoute] DeleteGameCommand command)
        {
            return ApiOk(await Mediator.Send(command));
        }
    }
}
