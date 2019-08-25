using System.Collections.Generic;
using MediatR;

namespace NotSteam.Core.App.Games.Queries.GetGamesMap
{
    public class GetGamesMapRequest : IRequest<IEnumerable<GamesMapEntryDto>>
    {
    }
}
