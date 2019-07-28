using NotSteam.Models.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models.Interfaces
{
    public interface IBaseDateable
    {
        [DataType(DataType.DateTime)]
        [CustomRequired]
        [CustomDateRange]
        DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        [CustomDateRange]
        DateTime? LastModifiedAt { get; set; }
    }
}

