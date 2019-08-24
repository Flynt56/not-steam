using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NotSteam.Core.Exceptions;
using NotSteam.Core.Interfaces.Repositories;
using NotSteam.Model.Models;

namespace NotSteam.Core.App.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand>
    {
        private readonly IAsyncRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public DeleteTagCommandHandler(IAsyncRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            var entity = await _tagRepository
                .GetByIdAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Tag), request.Id);
            }

            await _tagRepository
                .DeleteAsync(entity);

            return Unit.Value;
        }
    }
}
