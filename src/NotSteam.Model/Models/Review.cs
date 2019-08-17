using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using NotSteam.Core.Models.Attributes;

namespace NotSteam.Core.Models
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

