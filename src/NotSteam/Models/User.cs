using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class User : BaseModel
    {
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(32, MinimumLength = 1, ErrorMessage = "{0} requires {1} to {2} characters!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must provide a {0}!")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "{0} requires {1} to {2} characters!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [EmailAddress(ErrorMessage = "{0} incorrectly formatted!")]
        [StringLength(254, ErrorMessage = "{0} restricted to {1} characters!")]
        public string Email { get; set; }

        // Add a date range
        // Cannot insert a future date or today
        [Required(ErrorMessage = "{0} is required!")]
        [DataType(DataType.Date, ErrorMessage = "{0} incorrectly formatted!")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(48, ErrorMessage = "{0} must not exceed {1} characters!")]
        public string Nickname { get; set; }

        [Url]
        public string ProfileImageUri { get; set; }
    }
}