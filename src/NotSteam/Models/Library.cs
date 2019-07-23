using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Library
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        [Required(ErrorMessage = "You must provide a {0}!")]
        [DataType(DataType.Date, ErrorMessage = "Input must be date formatted!")]
        public DateTime DateAcquired { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be greater than 0!")]
        public int TotalPlayTimeHours { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Input must be date formatted!")]
        public DateTime LastPlayedDate { get; set; }
    }
}