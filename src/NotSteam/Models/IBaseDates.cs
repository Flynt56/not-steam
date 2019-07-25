using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models
{
    public interface IBaseDates
    {
        [Required(ErrorMessage = "Creation date is required!")]
        [DataType(DataType.DateTime)]
         DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
         DateTime? LastModifiedAt { get; set; }
    }
}
