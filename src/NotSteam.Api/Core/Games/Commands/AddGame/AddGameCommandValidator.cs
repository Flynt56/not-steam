using FluentValidation;

namespace NotSteam.Api.Core.Games.Commands.AddGame
{
    public class AddGameCommandValidator : AbstractValidator<AddGameCommand>
    {
        public AddGameCommandValidator()
        {
        }
    }
}
