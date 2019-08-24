using Microsoft.EntityFrameworkCore;
using NotSteam.Model.Models;

namespace NotSteam.Core.Interfaces.DB
{
    public interface INotSteamContext
    {
        DbSet<Company> Companies { get; set; }
        DbSet<Game> Games { get; set; }
        DbSet<GameTag> GameTags { get; set; }
        DbSet<Library> Libraries { get; set; }
        DbSet<Purchase> Purchases { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<AuthUser> Users { get; set; }
    }
}
