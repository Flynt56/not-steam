using MediatR;

namespace NotSteam.Core.App.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommand : IRequest<UpdateCompanyDto>
    {
        public int Id { get; set; }

        public UpdateCompanyDto Company { get; set; }
    }
}
