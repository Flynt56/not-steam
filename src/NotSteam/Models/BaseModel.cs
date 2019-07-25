using System;

namespace NotSteam.Models
{
    public class BaseModel : IBaseDates
    {
        public int Id { get; set; }

        private DateTime createdAt = DateTime.UtcNow;
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }

        private DateTime? lastModifiedAt;
        public DateTime? LastModifiedAt { get => lastModifiedAt; set => lastModifiedAt = value; }
    }
}