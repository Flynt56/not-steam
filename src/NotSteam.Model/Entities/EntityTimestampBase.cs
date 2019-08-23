using System;
using NotSteam.Model.Interfaces;

namespace NotSteam.Model.Models
{
    public abstract class EntityTimestampBase : IEntityTimestamp
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public bool IsUpdated => UpdatedAt.HasValue;
    }
}
