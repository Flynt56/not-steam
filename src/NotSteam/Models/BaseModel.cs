using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public class BaseModel
    {
        // CreatedAt se inicijalizira i nikad ne mijenja
        // LastModifiedAt se inicijalizira cim se kreira object
        // Datumi moraju biti unutar nekakvog intervala

        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide a creation date!")]
        [DataType(DataType.DateTime, ErrorMessage = "Input must be date formatted!")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime, ErrorMessage = "Input must be date formatted!")]
        public DateTime LastModifiedAt { get; set; } = DateTime.UtcNow;

        public void UpdateModificationDate()
        {
            LastModifiedAt = DateTime.UtcNow;
        }
    }
}