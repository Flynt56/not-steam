using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class LibraryDetails
    {
        public string OwnerUsername { get; set; }
        public string GameTitle { get; set; }
        public DateTime DateAcquired { get; set; }
        public int TotalPlayTimeHours { get; set; }
        public DateTime? LastPlayed { get; set; }

        public static Expression<Func<Library, LibraryDetails>> Projection
        {
            get
            {
                return library => new LibraryDetails
                {
                    OwnerUsername = library.User.Username,
                    GameTitle = library.Game.Title,
                    DateAcquired = library.DateAcquired,
                    TotalPlayTimeHours = library.TotalPlayTimeHours,
                    LastPlayed = library.LastPlayedDate
                };
            }
        }

        public static LibraryDetails Create(Library library)
        {
            return Projection.Compile().Invoke(library);
        }
    }
}
