using System.Collections.Generic;
using MediatR;

namespace NotSteam.Api.Core.Tags.Queries.GetTagsMap
{
    public class GetTagsMapQuery : IRequest<IEnumerable<TagsMapEntryDto>>
    {
    }
}
