using MediatR;

namespace NotSteam.Api.Core.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest
    {
        public int Id { get; set; }
    }
}
