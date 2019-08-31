using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using NotSteam.Model.Attributes;
using NotSteam.Model.Entities;

namespace NotSteam.Model.Identity.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        [CustomMaxStringLength(32)]
        public string Nickname { get; set; }

        [CustomRequired]
        [CustomDateRange]
        public DateTime DateOfBirth { get; set; }

        public int ProfileImageId { get; set; }

        public Image ProfileImage { get; set; }

        public ICollection<Library> Libraries { get; private set; } = new HashSet<Library>();
        public ICollection<Purchase> Purchases { get; private set; } = new HashSet<Purchase>();
        public ICollection<Review> Reviews { get; private set; } = new HashSet<Review>();
    }
}
