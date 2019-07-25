using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class BaseModelDates
    {
        [Required(ErrorMessage = "Creation date is required!")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime? LastModifiedAt { get; set; } = DateTime.UtcNow;
    }
}