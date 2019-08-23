using System;

namespace NotSteam.Model.Interfaces
{
    public interface IEntityTimestamp
    {
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }

        bool IsUpdated { get; }
    }
}
