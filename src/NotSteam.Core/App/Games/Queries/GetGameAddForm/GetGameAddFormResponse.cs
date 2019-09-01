using System.Collections.Generic;

namespace NotSteam.Core.App.Games.Queries.GetGameAddForm
{
    public class GetGameAddFormResponse
    {
        public IReadOnlyList<CompanyListEntryDto> Companies { get; set; } = new List<CompanyListEntryDto>();
    }
}
