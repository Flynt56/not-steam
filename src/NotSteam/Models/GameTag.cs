using Newtonsoft.Json;
using System;

namespace NotSteam.Models
{
    public class GameTag : IBaseDateable
    {
        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        public int TagId { get; set; }

        [JsonIgnore]
        public Tag Tag { get; set; }

        DateTime IBaseDateable.CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime? IBaseDateable.LastModifiedAt { get; set; }
    }
}