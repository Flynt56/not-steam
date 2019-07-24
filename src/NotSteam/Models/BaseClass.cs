using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class BaseClass
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide a creation date!")]
        [DataType(DataType.DateTime, ErrorMessage = "Input must be date formatted!")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime, ErrorMessage = "Input must be date formatted!")]
        public DateTime LastModifiedAt { get; set; }

        public void UpdateModificationDate()
        {
            LastModifiedAt = DateTime.UtcNow;
        }
    }
}