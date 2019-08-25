using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using NotSteam.Model.Attributes;

namespace NotSteam.Model.Models
{
    public class AuthUser : IdentityUser<int>
    {
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

        public ICollection<Library> Libraries { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
