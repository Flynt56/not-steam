using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.DeleteGame
{
    class DeleteGameCommandValidator : AbstractValidator<DeleteGameCommand>
    {
        public DeleteGameCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
