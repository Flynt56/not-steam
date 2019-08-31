using System.ComponentModel.DataAnnotations;
using NotSteam.Model.Attributes;
using NotSteam.Model.Entities;
using NotSteam.Model.Identity.Models;

namespace NotSteam.Model.Entities
{
    public class Review : ModelBase
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        [CustomRequired]
        [CustomRange(1, 10)]
        public int Rating { get; set; }

        [CustomMaxStringLength(1500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ApplicationUser User { get; set; }
        public Game Game { get; set; }
    }
}
