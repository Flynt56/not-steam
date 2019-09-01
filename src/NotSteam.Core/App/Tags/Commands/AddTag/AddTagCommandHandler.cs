using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Tags.Commands.AddTag
{
    public class AddTagCommandHandler : IRequestHandler<AddTagCommand, AddTagDto>
    {
        private readonly IAsyncRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public AddTagCommandHandler(IAsyncRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<AddTagDto> Handle(AddTagCommand request, CancellationToken cancellationToken)
        {
            return _mapper.Map<AddTagDto>(
                await _tagRepository
                .AddAsync(_mapper.Map<Tag>(request.Tag)));
        }
    }
}
