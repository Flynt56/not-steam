using System.Collections.Generic;
using MediatR;

namespace NotSteam.Api.Core.Games.Queries.GetGamesMap
{
    public class GetGamesMapRequest : IRequest<IEnumerable<GamesMapEntryDto>>
    {
    }
}
