using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.DB;
using NotSteam.Core.Models;
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

            var rawUser = new User
            {
                Id = user.Id,
                Username = user.Name,
                Password = user.Password,
                Email = user.Email,
                Nickname = user.Nick,
                DateOfBirth = user.DOB,
                ProfileImageUri = user.ProfileImageUri
            };

            _context.Entry(rawUser).State = EntityState.Modified;

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

        [HttpPost]
        public async Task<ActionResult<UserDetails>> PostUser(UserDetails user)
        {
            var rawUser = new User
            {
                Id = user.Id,
                Username = user.Name,
                Password = user.Password,
                Email = user.Email,
                Nickname = user.Nick,
                DateOfBirth = user.DOB,
                ProfileImageUri = user.ProfileImageUri
            };

            await _context.Users.AddAsync(rawUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
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

