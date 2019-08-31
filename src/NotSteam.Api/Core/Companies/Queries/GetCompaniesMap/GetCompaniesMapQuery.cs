using System.Collections.Generic;
using MediatR;

namespace NotSteam.Api.Core.Companies.Queries.GetCompaniesMap
{
    public class GetCompaniesMapQuery : IRequest<IEnumerable<CompaniesMapEntryDto>>
    {
    }
}
