using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Core.App.Tags.Commands.AddTag;
using NotSteam.Core.App.Tags.Commands.DeleteTag;
using NotSteam.Core.App.Tags.Commands.UpdateTag;
using NotSteam.Core.App.Tags.Queries.GetPaginatedTagsList;
using NotSteam.Core.App.Tags.Queries.GetTagDetail;
using NotSteam.Core.App.Tags.Queries.GetTagEditForm;

namespace NotSteam.Core.Controllers
{
    public class TagsController : AppController
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

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> GetEditData([FromRoute] GetTagEditFormRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOne(int id, [FromBody] UpdateTagDto tag)
        {
            return ApiOk(await Mediator.Send(new UpdateTagCommand { Id = id, Tag = tag }));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostOne([FromBody] AddTagDto tag)
        {
            return ApiOk(await Mediator.Send(new AddTagCommand { Tag = tag }));
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOne([FromQuery] DeleteTagCommand command)
        {
            return ApiOk(await Mediator.Send(command));
        }
    }
}
