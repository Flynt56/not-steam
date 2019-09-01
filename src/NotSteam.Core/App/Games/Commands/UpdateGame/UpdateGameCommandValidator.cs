using System;
using FluentValidation;

namespace NotSteam.Core.App.Games.Commands.UpdateGame
{
    public class UpdateGameCommandValidator : AbstractValidator<UpdateGameCommand>
    {
        public UpdateGameCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.UpdateGameDto.Id).NotEmpty();
            RuleFor(x => x.UpdateGameDto.Id).Equal(x => x.Id);
            RuleFor(x => x.UpdateGameDto.CompanyId).NotEmpty();

            RuleFor(x => x.UpdateGameDto.Title).NotEmpty().MaximumLength(250);
            RuleFor(x => x.UpdateGameDto.Description).MaximumLength(1500);
            RuleFor(x => x.UpdateGameDto.ReleaseDate).GreaterThan(DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc));
            RuleFor(x => x.UpdateGameDto.BasePrice).InclusiveBetween(0M, 99.99M);
        }
    }
}
