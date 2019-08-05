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

        public static Expression<Func<User, UserDetails>> Projection
        {
            get
            {
                return user => new UserDetails
                {
                    Name = user.Username,
                    Nick = user.Nickname,
                    Email = user.Email,
                    DateOfBirth = user.DateOfBirth
                };
            }
        }

        public static UserDetails Create(User user)
        {
            return Projection.Compile().Invoke(user);
        }
    }
}
