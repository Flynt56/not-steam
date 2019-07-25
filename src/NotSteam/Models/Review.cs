using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace NotSteam.Models
{
    public class Review : BaseModelDates
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
    }
}