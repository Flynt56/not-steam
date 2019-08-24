using MediatR;

namespace NotSteam.Core.App.Companies.Queries.GetCompanyDetail
{
    public class GetCompanyDetailQuery : IRequest<CompanyDetailDto>
    {
        public int Id { get; set; }
    }
}
