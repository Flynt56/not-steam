using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Core.App.Tags.Commands.AddTag;
using NotSteam.Core.App.Tags.Commands.DeleteTag;
using NotSteam.Core.App.Tags.Commands.UpdateTag;
using NotSteam.Core.App.Tags.Queries.GetPaginatedTagsList;
using NotSteam.Core.App.Tags.Queries.GetTagDetail;
using NotSteam.Core.App.Tags.Queries.GetTagsMap;

namespace NotSteam.Api.Controllers
{
    public class TagsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] GetPaginatedTagsListQuery query = null)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne([FromQuery] GetTagDetailQuery query)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await Mediator.Send(new GetTagsMapQuery()));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOne(int id, [FromBody] UpdateTagDto game)
        {
            return ApiOk(await Mediator.Send(new UpdateTagCommand { Id = id, UpdateTagDto = game }));
        }

        [HttpPost]
        public async Task<IActionResult> PostOne([FromBody] AddTagDto game)
        {
            return ApiOk(await Mediator.Send(new AddTagCommand { AddTagDto = game }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOne([FromQuery] DeleteTagCommand command)
        {
            return ApiOk(await Mediator.Send(command));
        }
    }
}
