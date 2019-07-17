using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.DB;
using NotSteam.Models;

namespace NotSteam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly NotSteamContext _context;

        public CompaniesController(NotSteamContext context)
        {
            _context = context;

            // Add default entries
            if (_context.Companies.Count() < 2)
            {
                _context.Companies.Add(new Company { Name = "Methesda Softworks" });
                _context.Companies.Add(new Company { Name = "CD Projekt Blue" });
                _context.SaveChanges();
            }
        }

        // GET api/companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            return await _context.Companies.ToListAsync();
        }

        // GET api/companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        // POST api/companies
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany([FromBody] Company item)
        {
            await _context.Companies.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompany), new { id = item.Id }, item);
        }

        // PUT api/companies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, [FromBody] Company item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
