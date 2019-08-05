using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class ReviewDetails
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static Expression<Func<Review, ReviewDetails>> Projection
        {
            get
            {
                return review => new ReviewDetails
                {
                };
            }
        }

        public static ReviewDetails Create(Review review)
        {
            return Projection.Compile().Invoke(review);
        }
    }
}
