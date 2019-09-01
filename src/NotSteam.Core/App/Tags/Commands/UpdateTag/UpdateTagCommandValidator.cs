using FluentValidation;

namespace NotSteam.Core.App.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandValidator : AbstractValidator<UpdateTagCommand>
    {
        public UpdateTagCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Tag.Id).NotEmpty();
            RuleFor(x => x.Id).Equal(x => x.Tag.Id);

            RuleFor(x => x.Tag.Name)
                .NotEmpty()
                .MaximumLength(48);

            RuleFor(x => x.Tag.Description)
                .MaximumLength(250);
        }
    }
}
