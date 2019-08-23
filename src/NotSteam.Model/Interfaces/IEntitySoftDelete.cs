using System;

namespace NotSteam.Model.Interfaces
{
    public interface IEntitySoftDelete
    {
        DateTime? DeletedAt { get; set; }

        bool IsDeleted { get; }
    }
}
