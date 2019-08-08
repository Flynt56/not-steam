using System;
using System.Linq.Expressions;
using NotSteam.Core.Models;

namespace NotSteam.Core.ViewModels
{
    public class ReviewDetails
    {
        public string User { get; set; }
        public string Game { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public static Expression<Func<Review, ReviewDetails>> Projection
        {
            get
            {
                return review => new ReviewDetails
                {
                    User = review.User.Username,
                    Game = review.Game.Title,
                    Rating = review.Rating,
                    Description = review.Description
                };
            }
        }

        public static ReviewDetails Create(Review review)
        {
            return Projection.Compile().Invoke(review);
        }
    }
}
