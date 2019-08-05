using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class TagDetails
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static Expression<Func<Tag, TagDetails>> Projection
        {
            get
            {
                return tag => new TagDetails
                {
                };
            }
        }

        public static TagDetails Create(Tag tag)
        {
            return Projection.Compile().Invoke(tag);
        }
    }
}
