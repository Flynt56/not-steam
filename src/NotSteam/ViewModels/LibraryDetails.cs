using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class LibraryDetails
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static Expression<Func<Library, LibraryDetails>> Projection
        {
            get
            {
                return library => new LibraryDetails
                {
                };
            }
        }

        public static LibraryDetails Create(Library library)
        {
            return Projection.Compile().Invoke(library);
        }
    }
}
