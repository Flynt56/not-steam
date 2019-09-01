using FluentValidation;

namespace NotSteam.Core.App.Tags.Commands.AddTag
{
    public class AddTagCommandValidator : AbstractValidator<AddTagCommand>
    {
        public AddTagCommandValidator()
        {
            RuleFor(x => x.Tag.Name)
                .NotEmpty()
                .MaximumLength(48);

            RuleFor(x => x.Tag.Description)
                .MaximumLength(250);
        }
    }
}
