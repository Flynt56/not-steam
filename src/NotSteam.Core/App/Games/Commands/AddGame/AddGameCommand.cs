﻿using MediatR;

namespace NotSteam.Core.App.Games.Commands.AddGame
{
    public class AddGameCommand : IRequest<AddGameDto>
    {
        public AddGameDto Game { get; set; }
    }
}
