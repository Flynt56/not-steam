using System.Collections.Generic;
using MediatR;

namespace NotSteam.Core.App.Companies.Queries.GetCompaniesMap
{
    public class GetCompaniesMapQuery : IRequest<IEnumerable<CompaniesMapEntryDto>>
    {
    }
}
