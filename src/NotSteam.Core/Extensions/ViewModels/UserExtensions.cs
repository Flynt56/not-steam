using NotSteam.Core.Models;
using NotSteam.Core.ViewModels;

namespace NotSteam.Core.Extensions.ViewModels
{
    public static class UserExtensions
    {
       public static UserDetails ToUserDetails(this User user)
       {
           return new UserDetails
           {
               Id = user.Id,
               Name = user.Username,
               Nick = user.Nickname,
               Password = user.Password,
               DOB = user.DateOfBirth,
               Email = user.Email,
               ProfileImageUri = user.ProfileImageUri
           };
       } 

       public static User ToUser(this UserDetails userDetails)
       {
           return new User
           {
               Id = userDetails.Id,
               Username = userDetails.Name,
               Nickname = userDetails.Nick,
               Password = userDetails.Password,
               DateOfBirth = userDetails.DOB,
               Email = userDetails.Email,
               ProfileImageUri = userDetails.ProfileImageUri
           };
       }
    }
}
