using FluentValidation;

namespace NotSteam.Api.Core.Games.Commands.UpdateGame
{
    public class UpdateGameCommandValidator : AbstractValidator<UpdateGameCommand>
    {
        public UpdateGameCommandValidator()
        {
        }
    }
}
