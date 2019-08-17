using System;
using System.ComponentModel.DataAnnotations;
using NotSteam.Model.Attributes;

namespace NotSteam.Model.Interfaces
{
    public interface ITimestamp
    {
        [DataType(DataType.DateTime)]
        [CustomRequired]
        [CustomDateRange]
        DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        [CustomDateRange]
        DateTime? UpdatedAt { get; set; }
    }
}
