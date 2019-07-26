using Newtonsoft.Json;
using NotSteam.Attributes;
using NotSteam.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Library : IBaseDateable
    {
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} is required!")]
        [CustomDateRange]
        public DateTime DateAcquired { get; set; } = DateTime.UtcNow;

        [Range(0, int.MaxValue, ErrorMessage = "{0} must be greater than {1}!")]
        public int TotalPlayTimeHours { get; set; }

        [DataType(DataType.Date)]
        [CustomDateRange]
        public DateTime? LastPlayedDate { get; set; }

        DateTime IBaseDateable.CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime? IBaseDateable.LastModifiedAt { get; set; }
    }
}

