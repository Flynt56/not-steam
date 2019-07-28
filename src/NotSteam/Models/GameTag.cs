using Newtonsoft.Json;
using NotSteam.Models.Interfaces;
using System;

namespace NotSteam.Models
{
    public class GameTag : ISoftDeletable, IBaseDateable
    {
        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        public int TagId { get; set; }

        [JsonIgnore]
        public Tag Tag { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastModifiedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

