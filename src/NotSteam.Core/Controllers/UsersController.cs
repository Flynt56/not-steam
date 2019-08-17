using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Extensions.BaseController;
using NotSteam.Core.ViewModels;

namespace NotSteam.Core.Controllers
{
    public class UsersController : BaseController
    {
        public UsersController(NotSteamContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersList>>> GetUsers()
        {
            return Ok(await _context.Users.ProjectTo<UsersList>(_mapper.ConfigurationProvider).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDetails>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDetails>(user));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, [FromBody]UserDetails user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            var userEntity = _mapper.Map<User>(user);

            this.ValidateViewModel(userEntity);

            if (ModelState.IsValid)
            {
                _context.Entry(userEntity).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await UserExists(id))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return AcceptedAtAction(nameof(GetUser), new { id = user.Id }, user);
            }

            return BadRequest(new ValidationProblemDetails(ModelState));
        }

        [HttpPost]
        public async Task<ActionResult<UserDetails>> PostUser(UserDetails user)
        {
            var userEntity = _mapper.Map<User>(user);

            this.ValidateViewModel(userEntity);

            if (ModelState.IsValid)
            {
                await _context.Users.AddAsync(userEntity);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
            }

            return BadRequest(new ValidationProblemDetails(ModelState));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private async Task<bool> UserExists(int id)
        {
            return await _context.Users.AnyAsync(e => e.Id == id);
        }
    }
}
