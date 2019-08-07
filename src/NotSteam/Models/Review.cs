using Newtonsoft.Json;
using NotSteam.Models.Attributes;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Review : BaseModel
    {
        public int UserId { get; set; }

        public int GameId { get; set; }

        [CustomRequired]
        [CustomRange(1, 10)]
        public int Rating { get; set; }

        [CustomMaxStringLength(1500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [JsonIgnore]
        virtual public User User { get; set; }
        [JsonIgnore]
        virtual public Game Game { get; set; }
    }
}

