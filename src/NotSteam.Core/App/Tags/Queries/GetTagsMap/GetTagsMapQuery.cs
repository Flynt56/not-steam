using System.Collections.Generic;
using MediatR;

namespace NotSteam.Core.App.Tags.Queries.GetTagsMap
{
    public class GetTagsMapQuery : IRequest<IEnumerable<TagsMapEntryDto>>
    {
    }
}
