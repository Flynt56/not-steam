using FluentValidation;

namespace NotSteam.Api.Core.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandValidator : AbstractValidator<DeleteTagCommand>
    {
        public DeleteTagCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
