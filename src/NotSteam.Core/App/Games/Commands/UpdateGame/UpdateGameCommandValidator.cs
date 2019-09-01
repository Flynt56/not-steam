using System;
using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.UpdateGame
{
    public class UpdateGameCommandValidator : AbstractValidator<UpdateGameCommand>
    {
        public UpdateGameCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.Game.Id).NotEmpty();
            RuleFor(x => x.Game.Id).Equal(x => x.Id);
            RuleFor(x => x.Game.CompanyId).NotEmpty();

            RuleFor(x => x.Game.Title).NotEmpty().MaximumLength(250);
            RuleFor(x => x.Game.Description).MaximumLength(1500);
            RuleFor(x => x.Game.ReleaseDate).GreaterThan(DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc));
            RuleFor(x => x.Game.BasePrice).InclusiveBetween(0M, 99.99M);
        }
    }
}
