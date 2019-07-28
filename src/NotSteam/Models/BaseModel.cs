using NotSteam.Models.Interfaces;
using System;

namespace NotSteam.Models
{
    public abstract class BaseModel : IBaseDateable, ISoftDeletable
    {
        public int Id { get; set; }

        // Inherited from IBaseDateable
        DateTime IBaseDateable.CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime? IBaseDateable.LastModifiedAt { get; set; }

        // Inherited from ISoftDeletable
        bool ISoftDeletable.IsDeleted { get; set; }
    }
}

