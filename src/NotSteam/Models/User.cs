using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class User : BaseClass
    {
        [Required(ErrorMessage = "You must provide a {0}!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        [EmailAddress(ErrorMessage = "You must provide a valid email address!")]
        public string Email { get; set; }

        // Add a date range
        // Cannot insert a future date or today
        [Required(ErrorMessage = "You must provide a {0}!")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Nickname { get; set; }

        [Url]
        public string ProfileImageUri { get; set; }
    }
}