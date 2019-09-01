using System;
using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.AddGame
{
    public class AddGameCommandValidator : AbstractValidator<AddGameCommand>
    {
        public AddGameCommandValidator()
        {
            RuleFor(x => x.Game.CompanyId).NotEmpty();

            RuleFor(x => x.Game.Title).NotEmpty().MaximumLength(250);
            RuleFor(x => x.Game.Description).MaximumLength(1500);
            RuleFor(x => x.Game.ReleaseDate).GreaterThan(DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc));
            RuleFor(x => x.Game.BasePrice).InclusiveBetween(0M, 99.99M);
        }
    }
}
