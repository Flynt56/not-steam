using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, UpdateTagDto>
    {
        private readonly IAsyncRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public UpdateTagCommandHandler(IAsyncRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<UpdateTagDto> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            await _tagRepository
                .UpdateAsync(_mapper.Map<Tag>(request.Tag));

            return request.Tag;
        }
    }
}
