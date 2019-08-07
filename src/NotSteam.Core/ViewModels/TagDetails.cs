using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class TagDetails
    {
        public string Name { get; set; }
        public int UsageAmount { get; set; }
        public string Description { get; set; }

        public static Expression<Func<Tag, TagDetails>> Projection
        {
            get
            {
                return tag => new TagDetails
                {
                    Name = tag.Name,
                    UsageAmount = tag.GameTags.Count,
                    Description = tag.Description
                };
            }
        }

        public static TagDetails Create(Tag tag)
        {
            return Projection.Compile().Invoke(tag);
        }
    }
}
