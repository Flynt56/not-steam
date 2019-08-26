using System;
using System.Collections.Generic;
using NotSteam.Model.Models;

namespace NotSteam.Model.Interfaces.Entities
{
    public interface IUser : IAggregateRoot
    {
        int Id { get; set; }

        string UserName { get; set; }
        string PasswordHash { get; set; }
        string Email { get; set; }

        string Nickname { get; set; }
        DateTime DateOfBirth { get; set; }
        string ProfileImageUri { get; set; }

        ICollection<Library> Libraries { get; set; }
        ICollection<Purchase> Purchases { get; set; }
        ICollection<Review> Reviews { get; set; }
    }
}
