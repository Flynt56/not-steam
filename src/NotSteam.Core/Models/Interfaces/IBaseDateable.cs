using System;
using System.ComponentModel.DataAnnotations;
using NotSteam.Core.Models.Attributes;

namespace NotSteam.Core.Models.Interfaces
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

