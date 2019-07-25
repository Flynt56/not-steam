using NotSteam.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public interface IBaseDateable
    {
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Creation date is required!")]
        [CustomDateRange]
        DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        [CustomDateRange]
        DateTime? LastModifiedAt { get; set; }
    }
}
