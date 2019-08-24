using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.UpdateGame
{
    class UpdateGameCommandValidator : AbstractValidator<UpdateGameDto>
    {
        public UpdateGameCommandValidator()
        {
        }
    }
}
