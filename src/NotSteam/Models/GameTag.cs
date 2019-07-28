using Newtonsoft.Json;

namespace NotSteam.Models
{
    public class GameTag : BaseModel
    {
        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        public int TagId { get; set; }

        [JsonIgnore]
        public Tag Tag { get; set; }
    }
}

