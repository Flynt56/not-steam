using System.Collections.Generic;

namespace NotSteam.Core.App.Games.Queries.GetPaginatedGamesList
{
    public class PaginatedGameListModel
    {
        public IReadOnlyList<GameListEntryModel> Games { get; set; } = new List<GameListEntryModel>();
    }
}
