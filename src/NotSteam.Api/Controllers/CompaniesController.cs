using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotSteam.Core.App.Companies.Commands.AddCompany;
using NotSteam.Core.App.Companies.Commands.DeleteCompany;
using NotSteam.Core.App.Companies.Commands.UpdateCompany;
using NotSteam.Core.App.Companies.Queries.GetCompanyDetail;
using NotSteam.Core.App.Companies.Queries.GetCompanyEditForm;
using NotSteam.Core.App.Companies.Queries.GetPaginatedCompaniesList;

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

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> GetEditData([FromRoute] GetCompanyEditFormRequest request)
        {
            return ApiOk(await Mediator.Send(request));
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOne(int id, [FromBody] UpdateCompanyDto company)
        {
            return ApiOk(await Mediator.Send(new UpdateCompanyCommand { Id = id, Company = company }));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostOne([FromBody] AddCompanyDto company)
        {
            return ApiOk(await Mediator.Send(new AddCompanyCommand { Company = company }));
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOne([FromQuery] DeleteCompanyCommand command)
        {
            return ApiOk(await Mediator.Send(command));
        }
    }
}
