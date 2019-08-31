using MediatR;

namespace NotSteam.Api.Core.Companies.Commands.AddCompany
{
    public class AddCompanyCommand : IRequest<AddCompanyDto>
    {
        public AddCompanyDto AddCompanyDto { get; set; }
    }
}
