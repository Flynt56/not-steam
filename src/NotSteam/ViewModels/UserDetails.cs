using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class UserDetails
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int ReviewsCreated { get; set; }
        public int PurchasesMade { get; set; }
        public int GamesOwned { get; set; }

        public static Expression<Func<User, UserDetails>> Projection
        {
            get
            {
                return user => new UserDetails
                {
                    Name = user.Username,
                    Nick = user.Nickname,
                    Email = user.Email,
                    DateOfBirth = user.DateOfBirth,
                    ReviewsCreated = user.Reviews.Count,
                    PurchasesMade = user.Purchases.Count,
                    GamesOwned = user.Libraries.Count
                };
            }
        }

        public static UserDetails Create(User user)
        {
            return Projection.Compile().Invoke(user);
        }
    }
}
