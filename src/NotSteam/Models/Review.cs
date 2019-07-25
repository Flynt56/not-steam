using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Review : IBaseDateable
    {
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Range(1, 10, ErrorMessage = "{0} restricted from {1} to {2}!")]
        public int Rating { get; set; }

        [StringLength(1500, ErrorMessage = "{0} restricted to {1} characters!")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        DateTime IBaseDateable.CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime? IBaseDateable.LastModifiedAt { get; set; }
    }
}
