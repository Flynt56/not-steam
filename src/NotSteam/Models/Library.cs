using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Library
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [DataType(DataType.Date)];
        public DateTime DateAcquired { get; set; } = DateTime.UtcNow;

        [Range(0, int.MaxValue, ErrorMessage = "{0} must be greater than {1}!")]
        public int TotalPlayTimeHours { get; set; }

        [DataType(DataType.Date)]
        public DateTime? LastPlayedDate { get; set; } 
    }
}