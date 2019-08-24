using System.Collections.Generic;
using MediatR;

namespace NotSteam.Core.App.Games.Queries.GetGameDetail
{
    public class GetGamesMapQuery : IRequest<IEnumerable<GamesMapEntryDto>>
    {
    }
}
