using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.AddGame
{
    public class AddGameCommandValidator : AbstractValidator<AddGameCommand>
    {
        public AddGameCommandValidator()
        {
        }
    }
}
