using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class GameDetails
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static Expression<Func<Game, GameDetails>> Projection
        {
            get
            {
                return game => new GameDetails
                {
                };
            }
        }

        public static GameDetails Create(Game game)
        {
            return Projection.Compile().Invoke(game);
        }
    }
}
