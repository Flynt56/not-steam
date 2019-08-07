using NotSteam.Core.Models.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Core.Models
{
    public class User : BaseEntity
    {
        [DataType(DataType.Text)]
        [CustomRequired]
        [StringLength(32, MinimumLength = 1, ErrorMessage = "\"{0}\" je ograničen između {1} i {2} znakova!")]
        [RegularExpression("^[a-zA-Z0-9_]{1,32}$", ErrorMessage = "{0} smije sadržavati ASCII alfanumeričke znakove i '_'!")]
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [CustomRequired]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "\"{0}\" je ograničen između {1} i {2} znakova!")]
        [RegularExpression("^[a-zA-Z0-9.!?@#$+_=-]{8,32}$", ErrorMessage = "\"{0}\" smije sadržavati ASCII alfanumeričke znakove i '.','!','?','@','#','$','+','-','=','_'!")]
        public string Password { get; set; }

        [CustomRequired]
        [EmailAddress(ErrorMessage = "\"{0}\" neispravno formatiran!")]
        [CustomMaxStringLength(254)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [CustomRequired]
        [CustomDateRange]
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Text)]
        [CustomMaxStringLength(32)]
        public string Nickname { get; set; }

        [DataType(DataType.ImageUrl)]
        [Url(ErrorMessage = "\"{0}\" neispravno formatiran URL!")]
        public string ProfileImageUri { get; set; }

        virtual public ICollection<Library> Libraries { get; set; }
        virtual public ICollection<Purchase> Purchases { get; set; }
        virtual public ICollection<Review> Reviews { get; set; }
    }
}

