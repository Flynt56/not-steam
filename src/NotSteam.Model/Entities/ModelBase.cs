using System;
using NotSteam.Model.Interfaces;

namespace NotSteam.Model.Models
{
    public abstract class ModelBase : IEntityTimestamp, IEntitySoftDelete
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public bool IsUpdated => UpdatedAt.HasValue;

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted => DeletedAt.HasValue;
    }
}
