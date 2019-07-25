using System;
using System.ComponentModel.DataAnnotations;
using NotSteam.Attributes;

namespace NotSteam.Models
{
    public class User : BaseModel
    {
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(32, MinimumLength = 1, ErrorMessage = "{0} requires {1} to {2} characters!")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z0-9_]{1,32}$", ErrorMessage = "{0} can only contain ASCII alphanumeric characters and '_'!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "{0} requires {1} to {2} characters!")]
        [DataType(DataType.Password)]
        [RegularExpression("^[a-zA-Z0-9.!?@#$+_=-]{8,32}$", ErrorMessage = "{0} can only contain ASCII alphanumeric characters and '.','!','?','@','#','$','+','-','=','_'!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [EmailAddress(ErrorMessage = "{0} incorrectly formatted!")]
        [StringLength(254, ErrorMessage = "{0} restricted to {1} characters!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [DataType(DataType.Date)]
        [NotSteamDateRange]
        public DateTime DateOfBirth { get; set; }

        [StringLength(48, ErrorMessage = "{0} restricted to {1} characters!")]
        [DataType(DataType.Text)]
        public string Nickname { get; set; }

        [Url]
        [DataType(DataType.ImageUrl)]
        public Uri ProfileImageUri { get; set; }
    }
}