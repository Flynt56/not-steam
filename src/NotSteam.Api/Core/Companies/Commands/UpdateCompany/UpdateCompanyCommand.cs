using MediatR;

namespace NotSteam.Api.Core.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommand : IRequest<UpdateCompanyDto>
    {
        public int Id { get; set; }

        public UpdateCompanyDto UpdateCompanyDto { get; set; }
    }
}
