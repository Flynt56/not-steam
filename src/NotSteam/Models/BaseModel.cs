using NotSteam.Models.Interfaces;
using System;

namespace NotSteam.Models
{
    public abstract class BaseModel : IBaseDateable, ISoftDeletable
    {
        // Inherited from IBaseDateable
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastModifiedAt { get; set; }

        // Inherited from ISoftDeletable
        public bool IsDeleted { get; set; } = false;
    }
}

