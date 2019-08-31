using MediatR;

namespace NotSteam.Api.Core.Companies.Queries.GetCompanyDetail
{
    public class GetCompanyDetailQuery : IRequest<CompanyDetailDto>
    {
        public int Id { get; set; }
    }
}
