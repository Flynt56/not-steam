﻿using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Requests;
using NotSteam.Core.Services.Contracts;
using NotSteam.Core.ViewModels.Tags;
using NotSteam.Infrastructure.DB;
using NotSteam.Model.Models;
using NotSteam.Shared.Extensions;
using NotSteam.Shared.Pagination;

namespace NotSteam.Core.Services
{
    public class TagService : BaseService, ITagService
    {
        private readonly NotSteamContext _context;
        private readonly IMapper _mapper;

        public TagService(NotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResult<TagsList>> GetPageAsync(TagPaginationRequest request)
        {
            var pagedResult = await _context
                .Tags
                .ProjectTo<TagsList>(_mapper.ConfigurationProvider)
                .ToPagedResultAsync(request);

            return pagedResult;
        }

        public async Task<TagDetails> GetByIdAsync(int id)
        {
            return await _context
                .Tags
                .Where(c => c.Id == id)
                .ProjectTo<TagDetails>(_mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var user = await _context
                .Tags
                .FindAsync(id);

            _context.Tags.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(Tag user)
        {
            await _context.Tags.AddAsync(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, Tag user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await _context.Tags.AnyAsync(e => e.Id == id);
        }
    }
}
