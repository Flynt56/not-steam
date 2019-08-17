using System;
using NotSteam.Model.Interfaces;

namespace NotSteam.Model.Models
{
    public abstract class BaseModel : ITimestamp, ISoftDeletable
    {
        // Inherited from IBaseDateable
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        // Inherited from ISoftDeletable
        public bool IsDeleted { get; set; } = false;
    }
}
