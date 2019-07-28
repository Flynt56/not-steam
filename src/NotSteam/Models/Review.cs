using Newtonsoft.Json;
using NotSteam.Models.Attributes;
using NotSteam.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class Review : ISoftDeletable, IBaseDateable
    {
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; }

        [CustomRequired]
        [CustomRange(1, 10)]
        public int Rating { get; set; }

        [CustomMaxStringLength(1500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastModifiedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

