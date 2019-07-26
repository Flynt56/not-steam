using NotSteam.Models.Interfaces;
using System;

namespace NotSteam.Models
{
    public abstract class BaseModel : IBaseDateable
    {
        public int Id { get; set; }

        DateTime IBaseDateable.CreatedAt { get; set; } = DateTime.UtcNow;
        DateTime? IBaseDateable.LastModifiedAt { get; set; }
    }
}

