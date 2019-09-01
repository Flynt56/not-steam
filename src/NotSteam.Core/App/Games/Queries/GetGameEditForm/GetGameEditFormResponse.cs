using System.Collections.Generic;

namespace NotSteam.Core.App.Games.Queries.GetGameEditForm
{
    public class GetGameEditFormResponse
    {
        public GameEditFormDto Game { get; set; }
        public IReadOnlyList<CompanyListEntryDto> Companies { get; set; } = new List<CompanyListEntryDto>();
    }
}
