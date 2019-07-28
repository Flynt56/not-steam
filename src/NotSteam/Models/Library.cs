using Newtonsoft.Json;
using NotSteam.Models.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Library : BaseModel
    {
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        [DataType(DataType.Date)]
        [CustomRequired]
        [CustomDateRange]
        public DateTime DateAcquired { get; set; } = DateTime.UtcNow;

        [Range(0, int.MaxValue, ErrorMessage = "\"{0}\" mora biti veći od {1}!")]
        public int TotalPlayTimeHours { get; set; }

        [DataType(DataType.Date)]
        [CustomDateRange]
        public DateTime? LastPlayedDate { get; set; }
    }
}

