using FluentValidation;

namespace NotSteam.Api.Core.Games.Commands.DeleteGame
{
    public class DeleteGameCommandValidator : AbstractValidator<DeleteGameCommand>
    {
        public DeleteGameCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
