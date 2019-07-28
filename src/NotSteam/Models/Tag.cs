using NotSteam.Models.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Tag : BaseEntity
    {
        [CustomRequired]
        [CustomMaxStringLength(48)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [CustomMaxStringLength(250)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ICollection<GameTag> GameTags { get; set; }
    }
}

