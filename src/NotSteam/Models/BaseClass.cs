using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class BaseClass
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime LastModifiedAt { get; set; }
    }
}