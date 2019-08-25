using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Core.App.Companies.Commands.AddCompany;
using NotSteam.Core.App.Companies.Commands.DeleteCompany;
using NotSteam.Core.App.Companies.Commands.UpdateCompany;
using NotSteam.Core.App.Companies.Queries.GetCompaniesMap;
using NotSteam.Core.App.Companies.Queries.GetCompanyDetail;
using NotSteam.Core.App.Companies.Queries.GetPaginatedCompaniesList;

namespace NotSteam.Api.Controllers
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
