using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.DeleteGame
{
    public class DeleteGameCommandValidator : AbstractValidator<DeleteGameCommand>
    {
        public DeleteGameCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
