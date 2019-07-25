using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using NotSteam.Attributes;

namespace NotSteam.Models
{
    public class User : BaseModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(32, MinimumLength = 1, ErrorMessage = "{0} requires {1} to {2} characters!")]
        [RegularExpression("^[a-zA-Z0-9_]{1,32}$", ErrorMessage = "{0} can only contain ASCII alphanumeric characters and '_'!")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "{0} requires {1} to {2} characters!")]
        [RegularExpression("^[a-zA-Z0-9.!?@#$+_=-]{8,32}$", ErrorMessage = "{0} can only contain ASCII alphanumeric characters and '.','!','?','@','#','$','+','-','=','_'!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [EmailAddress(ErrorMessage = "{0} incorrectly formatted!")]
        [StringLength(254, ErrorMessage = "{0} restricted to {1} characters!")]
        public MailAddress Email { get; set; } = new MailAddress("example@example.com");

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} is required!")]
        [CustomDateRange]
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Text)]
        [StringLength(32, ErrorMessage = "{0} restricted to {1} characters!")]
        public string Nickname { get; set; }

        [DataType(DataType.ImageUrl)]
        [Url]
        public Uri ProfileImageUri { get; set; }
    }
}