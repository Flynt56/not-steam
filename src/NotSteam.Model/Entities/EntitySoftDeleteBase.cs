using System;
using NotSteam.Model.Interfaces;

namespace NotSteam.Model.Models
{
    public abstract class EntitySoftDeleteBase : IEntitySoftDelete
    {
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted => DeletedAt.HasValue;
    }
}
