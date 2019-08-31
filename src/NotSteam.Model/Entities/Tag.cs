using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NotSteam.Model.Attributes;
using NotSteam.Model.Interfaces;
using NotSteam.Model.Entities;

namespace NotSteam.Model.Entities
{
    public class Tag : EntityBase, IAggregateRoot
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
