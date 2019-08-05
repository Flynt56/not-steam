using NotSteam.Models;
using System;
using System.Linq.Expressions;

namespace NotSteam.DTOs
{
    public class GameTagDetails
    {
        public string TagName { get; set; }
        public string GameTitle { get; set; }
        public DateTime DateAdded { get; set; }

        public static Expression<Func<GameTag, GameTagDetails>> Projection
        {
            get
            {
                return gameTag => new GameTagDetails
                {
                    TagName = gameTag.Tag.Name,
                    GameTitle = gameTag.Game.Title,
                    DateAdded = gameTag.CreatedAt
                };
            }
        }

        public static GameTagDetails Create(GameTag gameTag)
        {
            return Projection.Compile().Invoke(gameTag);
        }
    }
}
