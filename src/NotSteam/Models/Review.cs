using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Review : BaseModel
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        [Required(ErrorMessage = "You must specify a {0}!")]
        [Range(1, 10, ErrorMessage = "{0} must be between {1} and {2}!")]
        public int Rating { get; set; }

        public string Description { get; set; }
    }
}