using System;
using System.ComponentModel.DataAnnotations;
using NotSteam.Model.Attributes;

namespace NotSteam.Model.Models
{
    public class Library : ModelBase
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        [DataType(DataType.Date)]
        [CustomRequired]
        [CustomDateRange]
        public DateTime DateAcquired { get; set; } = DateTime.UtcNow;

        [Range(0, int.MaxValue, ErrorMessage = "\"{0}\" mora biti veći od {1}!")]
        public int TotalPlayTimeHours { get; set; }

        [DataType(DataType.Date)]
        [CustomDateRange]
        public DateTime? LastPlayedDate { get; set; }

        public User User { get; set; }
        public Game Game { get; set; }
    }
}
