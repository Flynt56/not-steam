using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class User : BaseModel
    {
        [Required(ErrorMessage = "You must provide a {0}!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must provide an {0} address!")]
        [EmailAddress(ErrorMessage = "You must provide a valid {0} address!")]
        [StringLength(254, ErrorMessage = "{0} must not exceed {1} characters!")]
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