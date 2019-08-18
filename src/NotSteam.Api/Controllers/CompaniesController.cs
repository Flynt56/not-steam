using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class CompaniesController : BaseController
    {
        private readonly ICompanyService CompanyService;

        public CompaniesController(ICompanyService companyService, NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
            CompanyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery]CompanyPaginationRequest request = null)
        {
            return ApiOk(await CompanyService.GetPageAsync(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            return ApiOk(await CompanyService.GetByIdAsync(id));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await CompanyService.GetDropdown());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, [FromBody]Company company)
        {
            if (id != company.Id)
            {
                return BadRequest();
            }

            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await CompanyService.DoesExist(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return AcceptedAtAction(nameof(GetOne), new { id = company.Id }, company);
        }

        [HttpPost]
        public async Task<IActionResult> PostCompany([FromBody]Company company)
        {
            return ApiOk(await CompanyService.AddAsync(company));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            return ApiOk(await CompanyService.DeleteByIdAsync(id));
        }
    }
}
