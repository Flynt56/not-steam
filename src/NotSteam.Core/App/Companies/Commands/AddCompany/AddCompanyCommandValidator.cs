using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.AddGame
{
    class AddGameCommandValidator : AbstractValidator<AddGameDto>
    {
        public AddGameCommandValidator()
        {
        }
    }
}
