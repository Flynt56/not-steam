using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.Services;
using NotSteam.Core.Requests;
using NotSteam.Core.ViewModels.Tags;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;

namespace NotSteam.Api.Controllers
{
    public class TagsController : BaseController
    {
        private readonly ITagService TagService;

        public TagsController(ITagService tagService, NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
            TagService = tagService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery]TagPaginationRequest request = null)
        {
            return ApiOk(await TagService.GetPageAsync(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            return ApiOk(await TagService.GetByIdAsync(id));
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdown()
        {
            return ApiOk(await TagService.GetDropdown());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTag(int id, [FromBody]Tag tag)
        {
            if (id != tag.Id)
            {
                return BadRequest();
            }

            _context.Entry(tag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await TagService.DoesExist(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return AcceptedAtAction(nameof(GetOne), new { id = tag.Id }, tag);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody]Tag tag)
        {
            return ApiOk(await TagService.AddAsync(tag));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            return ApiOk(await TagService.DeleteByIdAsync(id));
        }
    }
}
