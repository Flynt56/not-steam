using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NotSteam.Api.Controllers
{
    public class GameTagTagsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] GetPaginatedGameTagsListQuery query = null)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("{idGame}/{idTag}")]
        public async Task<IActionResult> GetOne([FromQuery] GetGameTagDetailQuery query)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await Mediator.Send(new GetGameTagsMapQuery()));
        }

        [HttpGet("{idGame}/{idTag}")]
        public async Task<IActionResult> PutOne(int idGame, int idTag, [FromBody] UpdateGameTagDto game)
        {
            return ApiOk(await Mediator.Send(new UpdateGameTagCommand { Id = id, UpdateGameTagDto = game }));
        }

        [HttpPost]
        public async Task<IActionResult> PostOne([FromBody] AddGameTagDto game)
        {
            return ApiOk(await Mediator.Send(new AddGameTagCommand { AddGameTagDto = game }));
        }

        [HttpGet("{idGame}/{idTag}")]
        public async Task<IActionResult> DeleteOne([FromQuery] DeleteGameTagCommand command)
        {
            return ApiOk(await Mediator.Send(command));
        }
    }
}
