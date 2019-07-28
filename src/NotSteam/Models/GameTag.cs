using System;
using Newtonsoft.Json;
using NotSteam.Models.Interfaces;

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

        bool ISoftDeletable.IsDeleted { get; set; }

        DateTime IBaseDateable.CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime? IBaseDateable.LastModifiedAt { get; set; }
    }
}

