using Newtonsoft.Json;

namespace NotSteam.Models
{
    public class GameTag : BaseModel
    {
        public int GameId { get; set; }

        public int TagId { get; set; }

        [JsonIgnore]
        virtual public Game Game { get; set; }
        [JsonIgnore]
        virtual public Tag Tag { get; set; }
    }
}

