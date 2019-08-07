using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class GameDetails
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BasePrice { get; set; }

        public string DeveloperName { get; set; }
        public ICollection<string> Tags { get; set; } = new HashSet<string>();
        public int Reviews { get; set; }
        public int Owners { get; set; }

        public static Expression<Func<Game, GameDetails>> Projection
        {
            get
            {
                return game => new GameDetails
                {
                    Title = game.Title,
                    Description = game.Description,
                    ReleaseDate = game.ReleaseDate,
                    BasePrice = game.BasePrice,

                    DeveloperName = game.Company.Name,
                    Tags = game.GameTags.Select(gt => gt.Tag.Name).ToHashSet(),
                    Reviews = game.Reviews.Count,
                    Owners = game.Libraries.Count
                };
            }
        }

        public static GameDetails Create(Game game)
        {
            return Projection.Compile().Invoke(game);
        }
    }
}
