using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Api.Core.Companies.Commands.AddCompany;
using NotSteam.Api.Core.Companies.Commands.DeleteCompany;
using NotSteam.Api.Core.Companies.Commands.UpdateCompany;
using NotSteam.Api.Core.Companies.Queries.GetCompaniesMap;
using NotSteam.Api.Core.Companies.Queries.GetCompanyDetail;
using NotSteam.Api.Core.Companies.Queries.GetPaginatedCompaniesList;

namespace NotSteam.Core.Controllers
{
    public class CompaniesController : AppController
    {
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] GetPaginatedCompaniesListQuery query = null)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne([FromQuery] GetCompanyDetailQuery query)
        {
            return ApiOk(await Mediator.Send(query));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await Mediator.Send(new GetCompaniesMapQuery()));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOne(int id, [FromBody] UpdateCompanyDto game)
        {
            return ApiOk(await Mediator.Send(new UpdateCompanyCommand { Id = id, UpdateCompanyDto = game }));
        }

        [HttpPost]
        public async Task<IActionResult> PostOne([FromBody] AddCompanyDto game)
        {
            return ApiOk(await Mediator.Send(new AddCompanyCommand { AddCompanyDto = game }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOne([FromQuery] DeleteCompanyCommand command)
        {
            return ApiOk(await Mediator.Send(command));
        }
    }
}
