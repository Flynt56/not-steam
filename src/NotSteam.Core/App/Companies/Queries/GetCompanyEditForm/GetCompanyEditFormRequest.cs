using MediatR;

namespace NotSteam.Core.App.Companies.Queries.GetCompanyEditForm
{
    public class GetCompanyEditFormRequest : IRequest<GetCompanyEditFormResponse>
    {
        public int Id { get; set; }
    }
}
