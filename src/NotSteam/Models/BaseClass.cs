using System;

namespace NotSteam.Models
{
    public class BaseClass
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime LastModifiedAt { get; set; }
    }
}