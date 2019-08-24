using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotSteam.Core.Interfaces.DB;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.GameTags.Commands.UpdateGameTag
{
    public class UpdateGameTagCommandHandler : IRequestHandler<UpdateGameTagCommand, UpdateGameTagDto>
    {
        private readonly INotSteamContext _context;
        private readonly IMapper _mapper;

        public UpdateGameTagCommandHandler(INotSteamContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UpdateGameTagDto> Handle(UpdateGameTagCommand request, CancellationToken cancellationToken)
        {
            _context.GameTags.Entry(_mapper.Map<GameTag>(request.UpdateGameTagDto)).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();


            return request.UpdateGameTagDto;
        }
    }
}
