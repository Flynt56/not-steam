using FluentValidation;

namespace NotSteam.Core.App.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandValidator : AbstractValidator<DeleteTagCommand>
    {
        public DeleteTagCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
